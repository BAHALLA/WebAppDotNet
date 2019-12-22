using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAppDotNet.Model;

namespace WebAppDotNet.Controllers{
    public class TestController: Controller{

        public IActionResult Index() {
            IList<string> items = new List<string>();
            items.Add("AAA");items.Add("BBB");items.Add("CCC");
            ViewData["email"] = "bahalla.taoufiq@gmail.com";
            return View(items);
        }

        public IActionResult List() {
            IList<Student> students = new List<Student>();
            students.Add(new Student{Id=1, Name= "taoufiq", Score= 77});
            students.Add(new Student{Id=2, Name= "Mohamed", Score= 87});
            students.Add(new Student{Id=3, Name= "Ibrahim", Score= 67});
            return View(students);
        } 
        public IActionResult A() {
            return View();
        }
    }
}