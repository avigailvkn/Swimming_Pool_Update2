using Microsoft.AspNetCore.Mvc;
using Swimming_Pool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming_Pool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
         static int CountTeacher = 1;
        static List<Teacher>TeacherList= new List<Teacher>{new Teacher
        {
            TeacherId=CountTeacher++,
            TeacherFirstName="avi",
            TeacherLastName="cohen",
            TeacherAddress="lando 32",
            TeacherPhone="0504125389",
            TeacherEmail="avi@gmail.com",
            TeacherStatus=true,
            TeacherDays=2,
            TeacherHour=DateTime.Now
        } };
        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return TeacherList;
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public Teacher Get(int TeacherId)
        {
            var obj = TeacherList.Find(p => p.TeacherId == TeacherId);
                if(obj!=null)
                return obj;
                return null;
        }

        // POST api/<TeachersController>
        [HttpPost]
        public void Post([FromBody] Teacher val)
        {
            TeacherList.Add(new Teacher
            {
                TeacherId = CountTeacher++,
                TeacherFirstName = val.TeacherFirstName,
                TeacherLastName = val.TeacherLastName,
                TeacherAddress = val.TeacherAddress,
                TeacherDays = val.TeacherDays,
                TeacherEmail = val.TeacherEmail,
                TeacherHour = val.TeacherHour,
                TeacherPhone = val.TeacherPhone,
                TeacherStatus = val.TeacherStatus,
            });
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Teacher val)
        {
            var obj=TeacherList.Find(p=>p.TeacherId==val.TeacherId);
            if(obj!=null)
            {
                obj.TeacherFirstName=val.TeacherFirstName;
                obj.TeacherLastName=val.TeacherLastName;
                obj.TeacherAddress=val.TeacherAddress;
                obj.TeacherDays = val.TeacherDays;
                obj.TeacherEmail = val.TeacherEmail;
                obj.TeacherHour = val.TeacherHour;
                obj.TeacherPhone = val.TeacherPhone;
                obj.TeacherStatus = val.TeacherStatus;

            }
        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int TeacherId)
        {
             var obj=TeacherList.Find(p=>p.TeacherId==TeacherId);
            if(obj != null)
                TeacherList.Remove(obj);
        }
    }
}
