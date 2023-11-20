namespace Swimming_Pool.Entities
{
    public class Teacher
    {
       
        public int TeacherId { get; set; }
        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }
        public string? TeacherAddress { get; set; }
        public string? TeacherPhone { get; set; }
        public string? TeacherEmail { get; set; }
        public bool TeacherStatus { get; set; }
        public int TeacherDays { get; set; }
        public DateTime TeacherHour { get; set; }


        //public Teacher(int TeacherId, string? TeacherFirstName, string? TeacherLastName,
        //    string? TeacherAddress, int TeacherPhone, string? TeacherEmail, bool TeacherStatus,
        //    TimeOnly TeacherHour, int TeacherDays)
        //{
        //    this.TeacherId = CountTeacher++;
        //    this.TeacherHour = TeacherHour;
        //    this.TeacherPhone = TeacherPhone;
        //    this.TeacherStatus = TeacherStatus;
        //    this.TeacherAddress = TeacherAddress;
        //    this.TeacherFirstName = TeacherFirstName;
        //    this.TeacherEmail = TeacherEmail;
        //    this.TeacherPhone = TeacherPhone;
        //    this.TeacherDays = TeacherDays;
        //}
    }
}
