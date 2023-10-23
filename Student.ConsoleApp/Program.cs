// See https://aka.ms/new-console-template for more information
using Student.ConsoleApp;

Console.WriteLine("----- START -----");

var nonStaticClass = new Student.ConsoleApp.Student();
var nonStaticClassFullName = nonStaticClass.GetFullName("Emri", "Mbiemri");
Console.WriteLine($"Full name (non-static) = {nonStaticClassFullName}");

var staticClassFullName = StudentStatic.GetFullName("Emri", "Mbiemri");
Console.WriteLine($"Full name (static) = {staticClassFullName}");



var student = new Student.ConsoleApp.Student()
{
    Id = 1,
    FirstName = "Student",
    LastName = "Fullname",
    Email = "student@email.com",
    EnrollmentYear = 2022,
    DOB = DateTime.UtcNow
};

//Console.WriteLine($"Student FullName: {student.FirstName} {student.LastName}");
//Console.WriteLine($"Student Email: {student.Email}");

//var studentOther = new Student.ConsoleApp.Student()
//{
//    Id = 2,
//    FirstName = "Other",
//    LastName = "Fullname",
//    Email = "student@other.com",
//    EnrollmentYear = 2021,
//    DOB = DateTime.UtcNow
//};

Console.WriteLine("----- END -----");
