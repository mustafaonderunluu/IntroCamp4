using IntroCamp.DataAccess.Abstracts;
using IntroCamp.DataAccess.Concretes;
using IntroCamp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCamp.Business;

public class CourseManager
{
    //dependency injection

   private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List <Course> GetAll()
    { 
        //business rules
      

        return _courseDal.GetAll();

     

    }








}
