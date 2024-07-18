// See https://aka.ms/new-console-template for more information
using Rimon_NATH_conDemo;

Console.WriteLine("Hello, World!");
string connectionString = "Server =.\\SQLEXPRESS; Database = ADO_DOT_NET; User Id = aspnetb9; Password = 123456; Trust Server Certificate=True;";
ADODBContext context = new ADODBContext(connectionString);
//var students = context.GetStudents();

//foreach (var item in students)
//{
//    Console.WriteLine($"ID: {item.Id} Name: {item.Name} Age: {item.Age}");
//}
//int id = int.Parse(Console.ReadLine());
//var student = context.GetStudent(id);
//Console.WriteLine($"ID: {student.Id} Name: {student.Name} Age: {student.Age}");

//Console.WriteLine("Give student data to add Student");
Console.Write("ID: ");
int id = int.Parse(Console.ReadLine());
//Console.Write("Name: ");
//string name = Console.ReadLine();
//Console.Write("Age: ");
//int age = int.Parse(Console.ReadLine());
//Student newstudent = new Student
//{
//    Id = id,
//    Name = name,
//    Age = age
//};
//context.AddStudent(newstudent);

var result = context.DeleteStudent(id);
Console.WriteLine(result);
 