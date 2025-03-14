namespace EF_Core.Entity
{
    public class MemberInstructor
    {
        public int MemberInstructorID { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; } = null!;
        public int InstructorID { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;
        public DateTime AssignDate { get; set; }

    }
}
