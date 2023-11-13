using EntityFrameworkCore_Task.Models;
using EntityFrameworkCore_Task.Services;

namespace EntityFrameworkCore_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add()
            //StudentService.AddStudent("Maryam", "Aliyeva", 21, 100);
            //StudentService.AddStudent("Narmin", "Ibrahimova", 20, 95);
            //StudentService.AddStudent("Konul", "Qasimova", 33, 82);
            //StudentService.AddStudent("Gulgaz", "Suleymanli", 20, 88);
            //StudentService.AddStudent("Ulvi", "Asadzada", 30, 55);
            //StudentService.AddStudent("Rasul", "Rustamli", 18, 100);
            //StudentService.AddStudent("Aysu", "Mikayilzada", 20, 64);
            //StudentService.AddStudent("Qamza", "Mirkishiyeva", 20, 77); 
            #endregion


            #region GetAll()
            //foreach(Student item in StudentService.GetAllStudents())
            //{
            //    Console.WriteLine(item.Name+" "+item.Surname);
            //} 
            #endregion


            #region GetById()
            //Student student = StudentService.GetStudentById(4);
            //Console.WriteLine(student.Name+" "+student.Surname); 
            #endregion


            #region UpdatePoint()
            //StudentService.UpdateStudentPoint(5, 99); 
            #endregion


            #region GetPoint()
            //Student student = StudentService.GetStudentIntermediatePoint(55,75);
            //Console.WriteLine(student.Name+" "+student.Surname); 
            #endregion


            #region Delete()
            //StudentService.DeleteStudent(9); 
            #endregion



        }
    }
}