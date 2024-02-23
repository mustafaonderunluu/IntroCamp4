using IntroCamp.DataAccess.Abstracts;
using IntroCamp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCamp.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.CourseName = "C# ";
        course1.Derscription = ". Net 8 vs....";
        course1.Price = 10;

        Course course2 = new Course();
        course2.Id = 2;
        course2.CourseName = "Java ";
        course2.Derscription = "Java 17 ....";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.CourseName = "Python  ";
        course3.Derscription = "Python 3.5 ...";
        course3.Price = 10;

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll() {

        return courses;
       //db işlemleri yapılır.
    }
    public void Add(Course course)
    {

       courses.Add(course);

    }
}


