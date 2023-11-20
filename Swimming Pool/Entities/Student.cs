namespace Swimming_Pool.Entities
{
    public class Student
    {
        public static int CountStudent = 0;
        public int StudentId { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? StudentAddress { get; set; }
        public string? StudentPhone { get; set; }
        public string? ParentsPhone { get; set; }
        public DateTime StudentDateOfBirth { get; set; }
        public string? StudentEmail { get; set; }
        public bool StudentStatus { get; set; }
        public string? StudentStatusDescription { get; set; }
        public int IdTeacher { get; set; }
        public int StudentDays { get; set; }
        public DateTime StudentHour { get; set; }
        public double StudentSeniority { get; set; }
        //public Student( string StudentFirstName, string StudentLastName,
        //    string? StudentAddress, int StudentPhone, int ParentsPhone, DateOnly StudentDateOfBirth
        //    , string? StudentEmail, bool StudentStatus, string? StudentStatusDescription)
        //{
        //    this.StudentId = CountStudent++;
        //    this.StudentFirstName = StudentFirstName;
        //    this.StudentLastName = StudentLastName;
        //    this.StudentAddress = StudentAddress;
        //    this.StudentPhone = StudentPhone;
        //    this.StudentStatus = StudentStatus;
        //    this.StudentStatusDescription = StudentStatusDescription;
        //    this.StudentDateOfBirth = StudentDateOfBirth;
        //    this.ParentsPhone = ParentsPhone;
        //    this.StudentEmail = StudentEmail;
        //}

    }
}

   

