using Domain.Models;
using Service.Helper;
using Service.Services.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Controllers
{
    public class StudentController
    {
        public void CreateStudent(StudentService studentService)
        {
            string name = Helper.ReadValidatedString("Invalid name! Enter again:");
            string surname = Helper.ReadValidatedString("Invalid surname! Enter again:");
            int age = Helper.ReadValidatedInt("Enter age:");
            int groupId = Helper.ReadValidatedInt("Enter group ID:");

            studentService.Create(groupId, new Student { Name = name, Surname = surname, Age = age });
            Helper.ColorWrite(ConsoleColor.Green, "Student created successfully!");
        }

        public void UpdateStudent(StudentService studentService)
        {
            int id = Helper.ReadValidatedInt("Enter student ID to update:");

            var student = studentService.GetById(id);

            if (student != null)
            {

                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter new surname: ");
                string newSurname = Console.ReadLine();
                int newAge = Helper.ReadValidatedInt("Enter new age:");

                studentService.Update(id, new Student { Name = newName, Surname = newSurname, Age = newAge });
                Helper.ColorWrite(ConsoleColor.Green, "Student updated successfully!");
            }
        }

        public void DeleteStudent(StudentService studentService)
        {
            int id = Helper.ReadValidatedInt("Enter student ID to delete:");
            var student = studentService.GetById(id);
            if (student != null)
            {
                studentService.Delete(id);

                Helper.ColorWrite(ConsoleColor.Green, "Student deleted successfully!");
            }
        }

        public void GetStudentById(StudentService studentService)
        {
            int id = Helper.ReadValidatedInt("Enter student ID:");
            var student = studentService.GetById(id);
            if (student != null)
                Console.WriteLine($"{student.Id}. {student.Name} {student.Surname} | Age: {student.Age} | Group: {student.CourseGroup?.Name}");
        }

        public void GetAllStudents(StudentService studentService)
        {
            var list = studentService.GetAll();
            if (list.Count == 0)
            {
                Helper.ColorWrite(ConsoleColor.Red, "There is no student!");
            }
            else
            {
                foreach (var s in list)
                    Console.WriteLine($"{s.Id}. {s.Name} {s.Surname} | {s.Age} | Group: {s.CourseGroup?.Name}");

            }
        }

        public void GetStudentsByAge(StudentService studentService)
        {
            int age = Helper.ReadValidatedInt("Enter age:");
            var list = studentService.GetAllByAge(age);
            if (list.Count == 0)
            {
                Helper.ColorWrite(ConsoleColor.Red, "There is no student with given age!");
            }
            else
            {
                foreach (var s in list)
                    Console.WriteLine($"{s.Id}. {s.Name} {s.Surname} | Age: {s.Age}");

            }
        }

        public void GetStudentsByGroup(StudentService studentService)
        {
            int groupId = Helper.ReadValidatedInt("Enter group ID:");
            var list = studentService.GetAllByGroupId(groupId);
            if (list.Count == 0)
            {
                Helper.ColorWrite(ConsoleColor.Red, "There is no student with given group ID!");
            }
            else
            {
                foreach (var s in list)
                    Console.WriteLine($"{s.Id}. {s.Name} {s.Surname}");
            }
        }

        public void SearchStudents(StudentService studentService)
        {
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();
            var list = studentService.SearchByNameOrSurname(keyword);
            foreach (var s in list)
                Console.WriteLine($"{s.Id}. {s.Name} {s.Surname} | Age: {s.Age}");
        }
    }
}
