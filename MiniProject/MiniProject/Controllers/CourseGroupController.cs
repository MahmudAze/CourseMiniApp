using Domain.Models;
using Service.Helper;
using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Controllers
{
    public class CourseGroupController
    {
        public void CreateCourseGroup(CourseGroupService groupService)
        {
            Console.Write("Enter group name: ");
            string name = Helper.ReadValidatedString("Group name is not valid. Enter again:");
            Console.Write("Enter teacher name: ");
            string teacher = Helper.ReadValidatedString("Teacher name is not valid. Enter again:");
            Console.Write("Enter room: ");
            string room = Helper.ReadNonEmptyString("Room cannot be empty. Enter again:");

            groupService.Create(new CourseGroup { Name = name, TeacherName = teacher, Room = room });
            Helper.ColorWrite(ConsoleColor.Green, "Group created successfully!");
        }

        public void UpdateCourseGroup(CourseGroupService groupService)
        {
            int id = Helper.ReadValidatedInt("Enter ID to update:");

            var group = groupService.GetById(id);

            if (group == null)
            {
                Helper.ColorWrite(ConsoleColor.Red, "There is no group with given ID!");
            }
            else
            {
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter new teacher name: ");
                string newTeacher = Console.ReadLine();
                Console.Write("Enter new room: ");
                string newRoom = Console.ReadLine();


                groupService.Update(id, new CourseGroup { Name = newName, TeacherName = newTeacher, Room = newRoom });
                Helper.ColorWrite(ConsoleColor.Green, "Group updated successfully!");
            }
        }

        public void DeleteCourseGroup(CourseGroupService groupService)
        {
            int id = Helper.ReadValidatedInt("Enter ID to delete:");

            var group = groupService.GetById(id);
            if (group != null)
            {

                groupService.Delete(id);
                Helper.ColorWrite(ConsoleColor.Green, "Group deleted successfully!");
            }
            else
            {
                Helper.ColorWrite(ConsoleColor.Red, "There is no group with given ID!");
            }

        }

        public void GetCourseGroupById(CourseGroupService groupService)
        {
            int id = Helper.ReadValidatedInt("Enter group ID:");
            var group = groupService.GetById(id);
            if (group != null)
                Console.WriteLine($"{group.Id} | {group.Name} | {group.TeacherName} | {group.Room}");
            else
                Helper.ColorWrite(ConsoleColor.Red, "Group not found!");
        }

        public void GetAllCourseGroups(CourseGroupService groupService)
        {
            var all = groupService.GetAll();

            if (all.Count == 0)
            {
                Helper.ColorWrite(ConsoleColor.Red, "There is no group!");
            }
            else
            {
                foreach (var g in all)
                    Console.WriteLine($"{g.Id}. {g.Name} | Teacher: {g.TeacherName} | Room: {g.Room}");
            }
        }

        public void GetCourseGroupsByTeacher(CourseGroupService groupService)
        {
            Console.Write("Enter teacher name: ");
            string teacher = Console.ReadLine();
            var list = groupService.GetAllByTeacherName(teacher);
            foreach (var g in list)
                Console.WriteLine($"{g.Id}. {g.Name} | {g.TeacherName}");
        }

        public void GetCourseGroupsByRoom(CourseGroupService groupService)
        {
            Console.Write("Enter room: ");
            string room = Console.ReadLine();
            var list = groupService.GetAllByRoom(room);
            foreach (var g in list)
                Console.WriteLine($"{g.Id}. {g.Name} | {g.Room}");
        }

        public void SearchCourseGroupsByName(CourseGroupService groupService)
        {
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();
            var list = groupService.SearchByName(keyword);
            foreach (var g in list)
                Console.WriteLine($"{g.Id}. {g.Name}");
        }
    }
}
