namespace Swimming_Pool.Entities
{
    public class Lesson
    {
      
        public int LessonId { get; set; }
        public string? LessonDescription { get; set;}
        public DateTime LessonHour { get; set;}
        public int TeacherId { get; set;}

        //public Lesson(string? LessonDescription, TimeOnly LessonHour, int TeacherId)
        //{
        //    this.LessonId = CountLesson++;
        //    this.LessonDescription = LessonDescription;
        //    this.LessonHour = LessonHour;
        //    this.TeacherId = TeacherId;
        //}
    }
}
