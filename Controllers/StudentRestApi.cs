using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAppDotNet.Model;

namespace WebAppDotNet.Controllers{

    [Route("/api/students")]
    public class StudentRestApi: Controller{

        private MyDBContext dbservice;

        public StudentRestApi(MyDBContext context){
            dbservice = context;
        }

        [HttpGet]
        public IEnumerable<Student> list() {
            return dbservice.Students;
        }
        [HttpGet("{Id}")]
        public Student GetOne(long id) {
            return dbservice.Students.FirstOrDefault( s => s.Id == id);
        }

        [HttpPost]
        public Student save([FromBody]Student student){
            dbservice.Add(student);
            dbservice.SaveChanges();
            return student;
        }

        [HttpDelete("{Id}")]
        public void Delete(long id) {
            Student student = dbservice.Students.FirstOrDefault( s => s.Id == id);
            dbservice.Students.Remove(student);
            dbservice.SaveChanges(); 
        }

        [HttpPut("{Id}")]
        public Student Update(long id, [FromBody] Student student) {
            student.Id = id;
            dbservice.Students.Update(student);
            dbservice.SaveChanges(); 
            return student;
        }
    }
}