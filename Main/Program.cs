
using Main.Business.Concretes;
using Main.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new CourseManager();
CategoryManager categoryManager = new CategoryManager();
InstructorManager instructorManager = new InstructorManager(); 

List<Category> categories = categoryManager.GetAll();
foreach (Category category in categories)
{
    Console.WriteLine(category.CategoryName+" : "+category.CategoryDescription);
}
Console.WriteLine();

List<Course> courses = courseManager.GetAll();
foreach (Course course in courses)
{
    Console.WriteLine(course.CourseName + " : "+course.CourseDescription);
}
Console.WriteLine();

Course course1 = new Course();
course1.CourseName = "C#";
course1.CourseDescription = "Learn C#";
course1.CourseId = 4;

courseManager.Add(course1);
foreach (Course course in courses)
{
    Console.WriteLine(course.CourseName + " : " + course.CourseDescription);
}
Console.WriteLine();
