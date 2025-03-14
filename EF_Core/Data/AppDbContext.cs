using EF_Core.Data.config;
using EF_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<BeltRank> BeltRanks { get; set; }
        public DbSet<BeltTest> BeltTests { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<SubscriptionPeriod> SubscriptionPeriods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MemberInstructor> MemberInstructors { get; set; }
        public DbSet<MembersDetails> MembersDetails { get; set; }
        public DbSet<MembersInstructorOverview> MembersInstructorOverview { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConfigrationBeltRank).Assembly);
            modelBuilder.HasDbFunction(typeof(AppDbContext).GetMethod(nameof(GetPassLastRankNameForTest),
                new[]
                {
                  typeof(int), typeof(int)
                }));
            modelBuilder.Ignore<MembersDetails>();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            IConfigurationRoot _configuration = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            string? ConnectionString = _configuration.GetSection("ConnectionString").Value;

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConnectionString).LogTo(log =>
            {
                // Filter out logs that contain the SQL command text
                if (log.Contains("Executed DbCommand"))
                {
                    // Handle INSERT commands with sensitive data
                    if (log.Contains("INSERT"))
                    {
                        var insertSql = log.Substring(log.IndexOf("INSERT"));
                        Console.WriteLine(insertSql);
                        Console.WriteLine();
                    }
                    // Handle UPDATE commands with sensitive data
                    else if (log.Contains("UPDATE"))
                    {
                        var updateSql = log.Substring(log.IndexOf("UPDATE"));
                        Console.WriteLine(updateSql);
                        Console.WriteLine();
                    }
                    // Handle DELETE commands with sensitive data
                    else if (log.Contains("DELETE"))
                    {
                        var deleteSql = log.Substring(log.IndexOf("DELETE"));
                        Console.WriteLine(deleteSql);
                        Console.WriteLine();
                    }
                    // Handle SELECT commands without sensitive data
                    else if (log.Contains("SELECT"))
                    {
                        var selectSql = log.Substring(log.IndexOf("SELECT"));
                        Console.WriteLine(selectSql);
                        Console.WriteLine();
                    }

                }
            }); ;
        }

        [DbFunction("CountBeltTests",Schema = "dbo")]
        public static int GetCountBeltTest()
        {
            //this does not need implemention;  Ef cor usee the function mapping
            throw new NotImplementedException();
        }


        [DbFunction("GetPassLastRankNameForTest", Schema = "dbo")]
        public  IQueryable<BeltTest> GetPassLastRankNameForTest(int memberID, int rankID)
        => FromExpression(() => GetPassLastRankNameForTest(memberID, rankID));


    }
}
