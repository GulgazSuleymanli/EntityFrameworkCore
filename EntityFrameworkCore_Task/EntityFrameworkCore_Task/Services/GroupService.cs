using EntityFrameworkCore_Task.DAL;
using EntityFrameworkCore_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Task.Services
{
    internal class GroupService
    {
        static AppDbContext dbContext = new AppDbContext();

        public static void AddGroup(string name)
        {
            Group group = new Group(name);
            dbContext.Groups.Add(group);
            dbContext.SaveChanges();
        }

        public static List<Group> GetAllGroups()
        {
            List<Group> groupsList = dbContext.Groups.ToList();
            return groupsList;
        }

        public static Group GetGroupById(int id)
        {
            Group group = dbContext.Groups.FirstOrDefault(x => x.Id == id);
            return group;
        }

        public static void DeleteStudent(int id)
        {
            if (GetGroupById(id) != null)
            {
                dbContext.Groups.Remove(GetGroupById(id));
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }

        public static void UpdateGroupName(int id, string name)
        {
            Group group = GetGroupById(id);
            if (group != null)
            {
                group.Name = name;
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Not found student");
            }
        }
    }
}
