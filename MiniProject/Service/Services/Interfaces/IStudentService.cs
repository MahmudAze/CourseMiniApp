using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        Student Create(Student student);
        void Update(Student student);
        void Delete(Student student);
        Student GetById(int id);
        List<Student> GetAll();
        List<Student> GetAllByAge(int age);
        List<Student> GetAllByGroupId(int groupId);
        List<Student> SearchByNameOrSurname(string keyword);
    }
}
