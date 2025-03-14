using EF_Core.Data;
using EF_Core.Entity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;


// First we need an instance of context
var context = new AppDbContext();


void _CallStoredProcedure()
        {
            using (var Context = new AppDbContext())
            {
                // var Paramter = new SqlParameter("@Par", System.Data.SqlDbType.Int)
                //{
                //  Value = 1
                //};
                //Context.MembersDetails.FromSql($"Exec dbo.SP_GetAllMembers{Paramter}");
                var Members=Context.MembersDetails.FromSql($"Exec dbo.SP_GetAllMembers").ToList();
                foreach (var item in Members)
                {
                    Console.WriteLine(item);
                }

            }
        }
 void _CallView()
        {
            using (var Context = new AppDbContext())
            {
                var MemberInstructors = Context.MembersInstructorOverview.ToList();
                foreach (var MemberInstructor in MemberInstructors)
                {
                    Console.WriteLine(MemberInstructor);
                }

            }
        }
 void _CallScalreFunction()
        {
            using (var Context = new AppDbContext())
            {
                var countBeltTest = Context.BeltTests
                      .Select(b => AppDbContext.GetCountBeltTest())
                      .FirstOrDefault();

                Console.WriteLine("Count Belt Tests = " + countBeltTest);
            }
        }
 void _CallTableFunction()
        {
            using (var Context = new AppDbContext())
            {
                
                foreach (var beltTest in Context.GetPassLastRankNameForTest(3,6).ToList())
                {

                    Console.WriteLine("Result = " + beltTest.Result);

                }

            }
        }
 void _CallQueryFilter()
        {
            using (var Context = new AppDbContext())
            {

                foreach (var beltTest in Context.Users)
                {

                    Console.WriteLine($"User Name = {beltTest.UserName} IsActive= {beltTest.IsActive}" );

                }

            }
        }

#region Raw SQL
//ExecutingRawSql();
//RawSqlWithLinq();
#endregion

#region Read Queries
// [Select all teams]
//await GetAllMembers();
//await GetAllMembersQuerySyntax();

// [Select one team]
//await GetOneMember();

// Select all record that meet a condition
// await GetFilteredMembers();

// Aggregate Methods
//await AggregateMethods();

// Grouping and Aggregating
//GroupByMethod();

// Ordering
//await OrderByMethods();

// Skip and Take - Great for Paging
//await SkipAndTake();

// Select and Projections - more precise queries
//await ProjectionsAndSelect();

// No Tracking - EF Core tracks objects that are returned by queries. This is less useful in
// disconnected applications like APIs and Web apps
//await NoTracking();

//IQueryable vs List Types
//await ListVsQueryable();
#endregion

#region Write Queries

// Simple Insert
//await InsertOneRecord();

// Loop Insert
//await InsertWithLoop();

// Batch Insert
//await InsertRange();

// Update Operations
//await UpdateWithTracking();
//await UpdateNoTracking();

// Delete Operations
//await DeleteRecord();

// Execute Delete
//await ExecuteDelete();

// Execute Update
//await ExecuteUpdate();

#endregion

#region Related Data
// Insert record with FK
//await InsertMember();

// Insert Parent/Child
//await InsertMemberInstructorWithMemberAndInstructor();

// Insert Parent with Children
//await InsertBeltRankWithMember();

// Eager Loading Data
//await EagerLoadingData();

// Explicit Loading Data
//await ExplicitLoadingData();

// Lazy Loading
await LazyLoadingData();

// Filtering Includes
// Get all teams and only home matches where they have scored
//await FilteringIncludes();

// Projects and Anonymous types
//await AnonymousTypesAndRelatedData();

#endregion

void ExecutingRawSql()
        {
            // FromSqlRaw()
            Console.WriteLine("Enter MemberInstructor ID: ");
            var MemberInstructor = Console.ReadLine();
            var MemberInstructorIDParam = new SqlParameter("MemberInstructorID", MemberInstructor);
            var MemberInstructors = context.MemberInstructors.FromSqlRaw($"SELECT * FROM MemberInstructors WHERE MemberInstructorID=@MemberInstructorID", MemberInstructorIDParam);
            foreach (var m in MemberInstructors)
            {
                Console.WriteLine(m.MemberInstructorID);
            }

            // FromSql()
            MemberInstructors = context.MemberInstructors.FromSql($"SELECT * FROM MemberInstructors WHERE MemberInstructorID={MemberInstructorIDParam}");
            foreach (var m in MemberInstructors)
            {
                Console.WriteLine(m.MemberInstructorID);
            }

            // FromSqlInterpolated
            MemberInstructors = context.MemberInstructors.FromSqlInterpolated($"SELECT * FROM MemberInstructors WHERE MemberInstructorID={MemberInstructorIDParam}");
             foreach (var m in MemberInstructors)
            {
                Console.WriteLine(m.MemberInstructorID);
            }
}
void RawSqlWithLinq()
{
    var MemberInstructors = context.MemberInstructors.FromSql($"SELECT * FROM MemberInstructors")
        .Where(x=>x.MemberInstructorID>5)
        .OrderBy(x=>x.MemberInstructorID)
        .Include("Member").ToList();
    foreach (var m in MemberInstructors)
    {
        Console.WriteLine(m.Member.Name);
    }
}
async Task GetAllMembers()
{
    // SELECT * FROM Teams
    var members = await context.Members.ToListAsync();

    foreach (var t in members)
    {
        Console.WriteLine(t.Name);
    }
}
async Task GetAllMembersQuerySyntax()
{
    Console.WriteLine("Enter Search Term");
    var searchTerm = Console.ReadLine();

    var Members = await (from member in context.Members
                             where EF.Functions.Like(member.Name, $"%{searchTerm}%")
                             select member)
                            .ToListAsync();
 

    foreach (var t in Members)
    {
        Console.WriteLine(t.Name);
    }
}
async Task GetOneMember()
{
    //Selecting a single record -First one in the list
    var MemberFirst = await context.MemberInstructors.Include("Member").FirstAsync();

    if (MemberFirst != null)
    {
        Console.WriteLine(MemberFirst.Member.Name);
    }

    var MemberFirstOrDefault = await context.MemberInstructors.FirstOrDefaultAsync();

    if (MemberFirstOrDefault != null)
    {
        Console.WriteLine(MemberFirstOrDefault.Member.Name);
    }

    //Selecting a single record -First one in the list that meets a condition
    var MemberFirstWithCondition = await context.BeltTests.FirstAsync(Test => Test.MemberID == 3);
    if (MemberFirstWithCondition != null)
    {
        Console.WriteLine(MemberFirstWithCondition.Member.Name);
    }

    var MemberFirstOrDefaultWithCondition = await context.BeltTests.FirstOrDefaultAsync(Test => Test.MemberID == 3);
    if (MemberFirstWithCondition != null)
    {
        Console.WriteLine(MemberFirstWithCondition.Member.Name);
    }

    //Selecting a single record -Only one record should be returned, or an exception will be thrown
    //var InstructSingl =await context.Instructors.SingleAsync(Ins => Ins.PersonID == 6);
    //if (InstructSingl != null)
    //{
    //    Console.WriteLine(InstructSingl.Name);
    //}
    var InstructSinglWithCondition = await context.Instructors.SingleAsync(Ins=>Ins.PersonID==6);
    if (InstructSinglWithCondition != null)
    {
        Console.WriteLine(InstructSinglWithCondition.Name);
    }
    
    var SingleOrDefault = await context.Instructors.SingleOrDefaultAsync(team => team.PersonID == 2);
    if (SingleOrDefault != null)
    {
        Console.WriteLine(SingleOrDefault.Name);
    }

    //Selecting based on Primary Key Id value
    var UserBasedOnId = await context.Users.FindAsync(1);
    if (UserBasedOnId != null)
    {
        Console.WriteLine(UserBasedOnId.Name);
    }
}
async Task GetFilteredMembers()
{
    Console.WriteLine("Enter Search Term");
    var searchTerm = Console.ReadLine();

    var MemberFiltered = await context.Members.Where(M => M.Name == searchTerm).ToListAsync();


    foreach (var item in MemberFiltered)
    {
        Console.WriteLine(item.Name);
    }

    var partialMembers = await context.Members.Where(m => EF.Functions.Like(m.Name, $"%{searchTerm}%")).ToListAsync();

    foreach (var item in partialMembers)
    {
        Console.WriteLine(item.Name);
    }
}
async Task AggregateMethods()
{
    // Count
    var NumberOfSubscriptionPeriods = await context.SubscriptionPeriods.CountAsync();
    Console.WriteLine($"Number Of SubscriptionPeriods: {NumberOfSubscriptionPeriods}");

    var NumberOfSubscriptionPeriodsWithConditon = await context.SubscriptionPeriods.CountAsync(s=>s.MemberID==3);
    Console.WriteLine($"Number Of SubscriptionPeriods with condition: {NumberOfSubscriptionPeriodsWithConditon}");

    // Max
    var maxBeltRanks = await context.BeltRanks.MaxAsync(q => q.TestFees);
    // Min
    var minBeltRanks = await context.BeltRanks.MinAsync(q => q.TestFees);
    // Average
    var avgBeltRanks = await context.BeltRanks.AverageAsync(q => q.TestFees);
    // Sum
    var sumBeltRanks = await context.BeltRanks.SumAsync(q => q.TestFees);


}
void GroupByMethod()
{
    var groubMemberInstructor = context.MemberInstructors
        .GroupBy(q => q.InstructorID)
        .ToList();

    foreach (var group in groubMemberInstructor)
    {
        Console.WriteLine("InstructorID= "+group.Key);
        foreach (var member in group)
        {
            Console.WriteLine(member.MemberID);

        }
    }

  }
async Task OrderByMethods()
{
    var orderPayment=await context.Payments.OrderBy(q=>q.Amount).ToListAsync();
    
    foreach (var item in orderPayment)
    {
        Console.WriteLine(item.PaymentID);
    }

    var descOrderPayment = await context.Payments
        .OrderByDescending(q => q.Amount)
        .ToListAsync();

    foreach (var item in descOrderPayment)
    {
        Console.WriteLine(item.PaymentID);
    }

    // Getting the record with a maximum value
    var maxByDescendingOrder = await context.Payments
    .OrderByDescending(q => q.Amount)
    .FirstOrDefaultAsync();

    var maxBy =  context.Payments.MaxBy(q => q.Amount);

    // Getting the record with a minimum value
    var minByDescendingOrder = await context.Payments
        .OrderBy(q => q.Amount)
        .FirstOrDefaultAsync();

    var minBy =  context.Payments.MinBy(q => q.Amount);

}
async Task SkipAndTake()
{
    var recordCount = 5;
    var page = 0;
    var next = true;
    while(next)
    {
        var Paymnets=await context.Payments.Skip(page* recordCount).Take(recordCount).ToListAsync();
        foreach (var item in Paymnets)
        {
            Console.WriteLine(item.PaymentID);

        }
        Console.WriteLine("Enter 'true' for the next set of records, 'false' to exit");
        next = Convert.ToBoolean(Console.ReadLine());

        if(!next)
        {
            break;

        }

        page += 1;


    }
}
async Task ProjectionsAndSelect()
{
    var members = await context.Members
        .Select(q => new MemberInfo { Id = q.PersonID, Name = q.Name }).ToListAsync();

    foreach (var member in members)
    {
        Console.WriteLine($"{member.Id} - {member.Name}");
    }
}
async Task NoTracking()
{
    var members = await context.Members.AsNoTracking().ToListAsync();
    
    foreach (var t in members)
    {
        Console.WriteLine(t.Name);
    }
}
async Task ListVsQueryable()
{
    Console.WriteLine("Enter '1' for member with Id 3 or 4 ");
    var option = Convert.ToInt32(Console.ReadLine());
    List<Member> MambersAsList = new List<Member>();

    // After executing to ToListAsync, the records are loaded into memory. Any operation is then done in memory
    MambersAsList = await context.Members.ToListAsync();
    if (option == 3)
    {
        MambersAsList = MambersAsList.Where(q => q.PersonID == 3).ToList();
    }
    else if (option == 4)
    {
        MambersAsList = MambersAsList.Where(q => q.PersonID==4).ToList();
    }

    foreach (var t in MambersAsList)
    {
        Console.WriteLine(t.Name);
    }

    // Records stay as IQueryable until the ToListAsync is executed, then the final query is performed. 
    var membersAsQueryable = context.Members.AsQueryable();
    if (option == 3)
    {
        membersAsQueryable = membersAsQueryable.Where(team => team.PersonID == 3);
    }

    if (option == 4)
    {
        membersAsQueryable = membersAsQueryable.Where(team => team.PersonID==4);
    }

    // Actual Query execution
    MambersAsList = await membersAsQueryable.ToListAsync();
    foreach (var t in MambersAsList)
    {
        Console.WriteLine(t.Name);
    }

}
async Task InsertOneRecord()
{
    var newUser = new User
    {
        PersonID = 100,
        Name = "Fahed Ahmed",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 1,
        Email = null,
        Phone = "7743928922",
        UserName = "All0",
        Password = "1234",
        IsActive = true,
        Permission = 1,
    };
    await context.Users.AddAsync(newUser);
    await context.SaveChangesAsync();
}
async Task InsertWithLoop()
{
    var newUser1 = new User
    {
        PersonID = 101,
        Name = "Fahed Ali",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 1,
        Email = null,
        Phone = "7743928922",
        UserName = "All0",
        Password = "1234",
        IsActive = true,
        Permission = 1,
    };
    var newUser2 = new User
    {
        PersonID = 102,
        Name = "Ayman Ahmed",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 0,
        Email = null,
        Phone = "7743928922",
        UserName = "All0",
        Password = "1234",
        IsActive = true,
        Permission = 1,
    };
    List<User> users = new List<User>
    {
        newUser1,
        newUser2
    };
    foreach (var coach in users)
    {
        await context.Users.AddAsync(coach);
    }
    await context.SaveChangesAsync();
}
async Task InsertRange()
{
    var newUser1 = new User
    {
        PersonID = 103,
        Name = "Fahed Ali",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 1,
        Email = null,
        Phone = "7743928922",
        UserName = "All0",
        Password = "1234",
        IsActive = true,
        Permission = 1,
    };
    var newUser2 = new User
    {
        PersonID = 104,
        Name = "Ayman Ahmed",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 0,
        Email = null,
        Phone = "7743928922",
        UserName = "All0",
        Password = "1234",
        IsActive = true,
        Permission = 1,
    };
    List<User> usera = new List<User>
    {
        newUser1,
        newUser2
    };
    await context.Users.AddRangeAsync(usera);
    await context.SaveChangesAsync();
}
async Task UpdateWithTracking()
{
    // Find uses tracking
    var user = await context.Users.FindAsync(104);
    user.Name = "Ahemd Waled";
    await context.SaveChangesAsync();
}
async Task UpdateNoTracking()
{
    // We cannot use `Find` method with no tracking enabled because it depends on tracking, so we look for the FirstOrDefault()
    var user = await context.Users
        .AsNoTracking()
        .FirstOrDefaultAsync(q => q.PersonID == 104);
    user.Name = "Testing No Tracking Behavior - Entity State Modified";

    // We can either call the Update() method or change the Entity State manually
    //context.Update(coach1);
    context.Entry(user).State = EntityState.Modified;
    await context.SaveChangesAsync();
}
async Task DeleteRecord()
{
    /* DELETE FROM Userss WHERE Id = 100 */
    var user = await context.Users.FindAsync(100);
    //context.Entry(user).State = EntityState.Deleted;
     context.Remove(user);
    await context.SaveChangesAsync();
}
async Task ExecuteDelete()
{
    await context.Payments.Where(x => x.PaymentID == 1).ExecuteDeleteAsync();
}
async Task ExecuteUpdate()
{
    await context.Payments.Where(p => p.PaymentID==6)
        .ExecuteUpdateAsync(set => set.
        SetProperty(c => c.Amount, 1000).
        SetProperty(c => c.Date, Convert.ToDateTime("2024-6-13")));


}
async Task InsertMember()
{
    var newMember1 = new Member
    {
        PersonID = 105,
        Name = "Fahed Ali",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 1,
        Email = null,
        Phone = "7743928922",
        EmergencyContactInfo = "All0",
        LastBeltRankID = 1,
        IsActive = true,
    };
    await context.AddAsync(newMember1);
    await context.SaveChangesAsync();
    /* Incorrect reference data  - Will give error*/
    var newMember2 = new Member
    {
        PersonID = 106,
        Name = "Ayman Ahmed",
        Address = "2Street",
        DateOfBirth = Convert.ToDateTime("2000-2-1"),
        Gender = 0,
        Email = null,
        Phone = "7743928922",
        EmergencyContactInfo = "All0",
        LastBeltRankID = 0,
        IsActive = true,
    };

    await context.AddAsync(newMember2);
    await context.SaveChangesAsync();
}
async Task InsertMemberInstructorWithMemberAndInstructor()
{
    var MemberInstructor = new MemberInstructor
    {
        MemberInstructorID=100,
        Member=new Member
        {
            PersonID = 107,
            Name = "Fahed Ali",
            Address = "2Street",
            DateOfBirth = Convert.ToDateTime("2000-2-1"),
            Gender = 1,
            Email = null,
            Phone = "7743928922",
            EmergencyContactInfo = "All0",
            LastBeltRankID = 1,
            IsActive = true,
        },
        Instructor =new Instructor
        {
            PersonID = 108,
            Name = "Fahed Ali",
            Address = "2Street",
            DateOfBirth = Convert.ToDateTime("2000-2-1"),
            Gender = 1,
            Email = null,
            Phone = "7743928922",
            Qualification = "All0",
        },
        AssignDate=DateTime.Now,

    };
    await context.AddAsync(MemberInstructor);
    await context.SaveChangesAsync();
}
async Task InsertBeltRankWithMember()
{
    var BeltRank = new BeltRank
    {    BeltRankID=100,
        RankName = "Mine",
        TestFees = 100M,
        Members = new List<Member>
        {
            new Member
            {
            PersonID = 110,
            Name = "Fahed Ali",
            Address = "2Street",
            DateOfBirth = Convert.ToDateTime("2000-2-1"),
            Gender = 1,
            Email = null,
            Phone = "7743928922",
            EmergencyContactInfo = "All0",
            IsActive = true,
            },
             new Member
            {
            PersonID = 111,
            Name = "Waleed Ali",
            Address = "2Street",
            DateOfBirth = Convert.ToDateTime("2000-2-1"),
            Gender = 1,
            Email = null,
            Phone = "7743928922",
            EmergencyContactInfo = "All0",
            IsActive = true,
            },
        }
    };
    await context.AddAsync(BeltRank);
    await context.SaveChangesAsync();
}
async Task EagerLoadingData()
{
    var memberInstructors = await context.MemberInstructors
        .Include(q => q.Member)
        .ThenInclude(m => m.BeltRank)
        .ToListAsync();
    

    foreach (var memberInstructor in memberInstructors)
    {
        Console.WriteLine($"Member - {memberInstructor.Member.Name}");
        Console.WriteLine($"Rank Name - {memberInstructor.Member.BeltRank.RankName}");
        
    }
}
async Task ExplicitLoadingData()
{
    var member = await context.FindAsync<Member>(3);
    if (!member.BeltTests.Any())
    {
        Console.WriteLine("BeltTests have not been loaded");
    }

    await context.Entry(member)
        .Collection(q => q.BeltTests)
        .LoadAsync();

    if (member.BeltTests.Any())
    {
        foreach (var beltTest in member.BeltTests)
        {
            Console.WriteLine($"{beltTest.BeltTestID}");
        }
    }
}
async Task LazyLoadingData()
{
    var member = await context.FindAsync<Member>(3);
    foreach (var beltTest in member.BeltTests)
    {
        Console.WriteLine($"{beltTest.BeltTestID}");
    }
}
class MemberInfo
{
        public int Id { get; set; }
        public string Name { get; set; }
}

//_CallStoredProcedure();
//_CallView();
//_CallScalreFunction();
//_CallTableFunction();
//_CallQueryFilter();

