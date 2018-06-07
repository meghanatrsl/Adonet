using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adonetdetails.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace adonetdetails
{
    public class StudentController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            Studentdataaccess studentDataAccessLayer = new Studentdataaccess();
            IEnumerable<Student> result = studentDataAccessLayer.GetAllStudents();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            Studentdataaccess studentDataAccessLayer = new Studentdataaccess();
            IEnumerable<Student> result = studentDataAccessLayer.GetAllStudents();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

