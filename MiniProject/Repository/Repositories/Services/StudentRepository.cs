using Domain.Models;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Services
{
    internal class StudentRepository : IStudentRepository
    {
        public void Create(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll(Predicate<Student>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
