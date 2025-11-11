using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
    public class StudentService : IStudentService
    {
        public Student Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllByAge(int age)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchByNameOrSurname(string keyword)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
