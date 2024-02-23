// See https://aka.ms/new-console-template for more information


using IntroCamp.Business;
using IntroCamp.DataAccess.Concretes;
using IntroCamp.Entities;

//course course1 = new course();
//course1.ıd = 1;
//course1.coursename = "c# ";
//course1.derscription = ". net 8 vs....";
//course1.price = 10;

//course course2 = new course();
//course2.ıd = 2;
//course2.coursename = "java ";
//course2.derscription = "java 17 ....";
//course2.price = 10;

//course course3 = new course();
//course3.ıd = 2;
//course3.coursename = "python  ";
//course3.derscription = "python 3.5 ...";
//course3.price = 10;
//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{

//    Console.WriteLine(courses[i].coursename + "/ " + courses[i].price);

//}
CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++) {


    Console.WriteLine(courses2[i].CourseName+"/ " + courses2[i].Price);
}

Console.WriteLine("Kod Bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "515619816";
customer1.FirstName = "Önder";
customer1.LastName = "Ünlü";
customer1.CustomerNumber = "157817";
IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "515619816";
customer2.FirstName = "Deniz";
customer2.LastName = "Çınar";
customer2.CustomerNumber = "16467";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "74581";
customer3.TaxNumber = "494855198";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Udemy";
customer4.CustomerNumber = "191151";
customer4.TaxNumber = "168498415";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
//polymorphism 
foreach(BaseCustomer customer in customers) {

    Console.WriteLine(customer.CustomerNumber);

}



Console.ReadLine();
