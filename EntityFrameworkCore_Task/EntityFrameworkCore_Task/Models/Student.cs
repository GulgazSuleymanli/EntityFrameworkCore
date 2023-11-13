using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Task.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public decimal Point { get; set; }
        public int GroupId { get; set; }
        public Student(string name, string surname, byte age, decimal point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
    }
}
