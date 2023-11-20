using Microsoft.AspNetCore.Mvc;
using Swimming_Pool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming_Pool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresenceController : ControllerBase
    {

        static List<Presence> PresenceList = new List<Presence> { new Presence
        { LessonId = 1, TeacherId=1, StudentId =1, IsPresent =true} };
        // GET: api/<PresenceController>
        [HttpGet]
        public IEnumerable<Presence> Get()
        {
            return PresenceList;
        }

        // GET api/<PresenceController>/5
        [HttpGet("{id,id,id}")]
        public Presence Get(int LessonId,int TeacherId, int StudentId)
        {
            var obj = PresenceList.Find(p => p.LessonId == LessonId && p.TeacherId == TeacherId && p.StudentId == StudentId);
            if(obj==null)
                return null;
            return obj;
        }

        // POST api/<PresenceController>
        [HttpPost]
        public void Post([FromBody] Presence val)
        {
            PresenceList.Add(new Presence
            {
                LessonId = val.LessonId,
                TeacherId = val.TeacherId,
                StudentId = val.StudentId,
                IsPresent = val.IsPresent
            });
        }

        // PUT api/<PresenceController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Presence val)
        {
             var obj=PresenceList.Find(p=>p.LessonId== val.LessonId);
            if (obj != null)
            {
                obj.StudentId=val.StudentId;
                obj.IsPresent=val.IsPresent;
                obj.LessonId=val.LessonId;
                obj.TeacherId=val.TeacherId;
            }

        }

        // DELETE api/<PresenceController>/5
        [HttpDelete("{id}")]
        public void Delete(int  LessonId)
        {
            var obj = PresenceList.Find(p => p.LessonId == LessonId);
                if(obj != null)
            {
                PresenceList.Remove(obj);
            }
        }
    }
}
