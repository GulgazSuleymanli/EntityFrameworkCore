using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Task.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
        }
    }
}
