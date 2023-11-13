using EntityFrameworkCore_Task.DAL;
using EntityFrameworkCore_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Task.Services
{
    internal class StudentService
    {
        static AppDbContext dbContext = new AppDbContext();

        public static void AddStudent(string name,string surname,byte age,decimal point)
        {
            Student student = new Student(name,surname,age,point);
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }

        public static List<Student> GetAllStudents() 
        {
            List<Student> studentsList = dbContext.Students.ToList();
            return studentsList;
        }

        public static Student GetStudentById(int id)
        {
            Student student = dbContext.Students.FirstOrDefault(x => x.Id == id);
            return student;
        }

        public static void DeleteStudent(int id)
        {
            if(GetStudentById(id) != null)
            {
                dbContext.Students.Remove(GetStudentById(id));
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }

        public static void UpdateStudentName(int id, string name)
        {
            Student student =GetStudentById(id);
            if (student != null)
            {
                student.Name = name;
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }

        public static void UpdateStudentSurname(int id, string surname)
        {
            Student student = GetStudentById(id);
            if (student != null)
            {
                student.Surname = surname;
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }

        public static void UpdateStudentAge(int id, byte age)
        {
            Student student = GetStudentById(id);
            if (student != null)
            {
                student.Age = age;
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }

        public static void UpdateStudentPoint(int id, decimal point)
        {
            Student student = GetStudentById(id);
            if (student != null)
            {
                student.Point = point;
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }

        public static Student GetStudentByPoint(decimal point)
        {
            Student student = dbContext.Students.FirstOrDefault(x => x.Point == point);
            return student;
        }

        public static Student GetStudentGreaterThanPoint(decimal point)
        {
            Student student = dbContext.Students.FirstOrDefault(x => x.Point >= point);
            return student;
        }

        public static Student GetStudentLessThanPoint(decimal point)
        {
            Student student = dbContext.Students.FirstOrDefault(x => x.Point <= point);
            return student;
        }

        public static Student GetStudentIntermediatePoint(decimal minpoint, decimal maxpoint)
        {
            Student student = dbContext.Students.FirstOrDefault(x => x.Point <= maxpoint && x.Point >= minpoint);
            return student;
        }
    }
}
