using Microsoft.AspNetCore.Mvc;
using Swimming_Pool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming_Pool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        static int LessonCount = 1;
        static List<Lesson> LessonList = new List<Lesson> { new Lesson { 
            LessonId=LessonCount++, 
            LessonDescription = "שיפור שחיה", 
            LessonHour =DateTime.Now 
            ,TeacherId=1}, 
            new Lesson { LessonId=LessonCount++,
                LessonDescription = "שחיה מתחילות",
                LessonHour =DateTime.Now ,
                TeacherId=2}
        };


        // GET: api/<LessonController>
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return LessonList ;
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public Lesson Get(int LessonId)
        {
         var obj=  LessonList.Find(p=>p.LessonId==LessonId);
            if(obj != null)
                return obj;
            return null;
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Lesson val)
        {
            LessonList.Add(new Lesson
            {
                LessonId = LessonCount++,
                LessonDescription = val.LessonDescription
                ,
                LessonHour = val.LessonHour,
                TeacherId = val.TeacherId
            });
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Lesson val)
        {
            var obj=LessonList.Find(p=>p.LessonId==val.LessonId);
            if (obj != null)
            {
                obj.LessonDescription=val.LessonDescription;
                obj.LessonHour=val.LessonHour;
                obj.TeacherId=val.TeacherId;

            }
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public void Delete(int LessonId)
        {
            var obj = LessonList.Find(p => p.LessonId == LessonId);
                if(obj != null)
                LessonList.Remove(obj);
        }
    }
}
