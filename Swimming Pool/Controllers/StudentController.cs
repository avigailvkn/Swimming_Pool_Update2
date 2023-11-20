using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swimming_Pool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swimming_Pool.Controllers
{ 
    
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static int StudentCount = 1;

        static List<Student> StudentList = new List<Student> { new Student
        { StudentId = StudentCount++, StudentFirstName = "elish",
        StudentLastName = "katz", StudentAddress = "Sorotzkin4", StudentPhone = "0504153454",
            ParentsPhone = "0504153089",StudentDateOfBirth = DateTime.Now, StudentEmail = "elishstar1@gmail.com",
        StudentStatus = true, StudentStatusDescription = "שחיה חופשית" }, new Student
        { StudentId = StudentCount++, StudentFirstName = "avigail",
        StudentLastName = "vaknin", StudentAddress = "Shderot78", StudentPhone = "0578153784",
            ParentsPhone = "0504153089",StudentDateOfBirth = DateTime.Now, StudentEmail = "e7878@gmail.com",
        StudentStatus = false, StudentStatusDescription = "מתחילים" } };    
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return StudentList;
        }
       

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int StudentId)
        {
            var obj = StudentList.Find(p => p.StudentId == StudentId);
            if (obj == null)
                return null;
            
            return obj;
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student val)
        {
            StudentList.Add(new Student
            {
                StudentId = val.StudentId,
                StudentFirstName = val.StudentFirstName,
                StudentLastName = val.StudentLastName,
                StudentAddress = val.StudentAddress,
                StudentPhone
            = val.StudentPhone
            ,
                ParentsPhone
            = val.ParentsPhone
            ,
                StudentDateOfBirth
            = val.StudentDateOfBirth
            ,
                StudentEmail
            = val.StudentEmail
            ,
                StudentStatus
            = val.StudentStatus
            ,
                StudentStatusDescription
            = val.StudentStatusDescription
            ,
                IdTeacher
            = val.IdTeacher
            ,
                StudentDays
            = val.StudentDays
            ,
                StudentHour
            = val.StudentHour
            ,
                StudentSeniority
            = val.StudentSeniority
            });
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student val)
        {
            var obj=StudentList.Find(p => p.StudentId == val.StudentId);
            if(obj != null)
            {
                obj.StudentId=val.StudentId;
                obj.StudentFirstName=val.StudentFirstName;
                obj.StudentLastName=val.StudentLastName;
                obj.StudentAddress=val.StudentAddress;
                obj.StudentPhone=val.StudentPhone;
                obj.ParentsPhone=val.ParentsPhone;
                obj.StudentDateOfBirth=val.StudentDateOfBirth;
                obj.StudentEmail=val.StudentEmail;
                obj.StudentStatus=val.StudentStatus;
                obj.StudentStatusDescription=val.StudentStatusDescription;
                obj.IdTeacher=val.IdTeacher;
                    obj.StudentDays=val.StudentDays;
                obj.StudentHour=val.StudentHour;
                obj.StudentSeniority=val.StudentSeniority;
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int StudentId)
        {
            var obj = StudentList.Find(p => p.StudentId == StudentId);
                if (obj != null)
            {
                StudentList.Remove(obj);
            }
        }
    }
}
