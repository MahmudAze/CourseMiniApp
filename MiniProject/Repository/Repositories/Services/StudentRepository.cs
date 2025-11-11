using Domain.Models;
using Repository.Contexts;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Services
{
    public class StudentRepository : IStudentRepository
    {
        public void Create(Student entity)
        {
            AppDbContext<Student>.Entities.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = AppDbContext<Student>.Entities.Find(s => s.Id == id);
            AppDbContext<Student>.Entities.Remove(entity);
        }

        public List<Student> GetAll(Predicate<Student?> predicate = null)
        {
            if (predicate == null)
            {
                return AppDbContext<Student>.Entities;
            }

            return AppDbContext<Student>.Entities.FindAll(predicate);
        }

        public Student GetById(int id)
        {
            return AppDbContext<Student>.Entities.Find(s => s.Id == id);
        }

        public void Update(int id, Student entity)
        {
            var existingEntity = AppDbContext<Student>.Entities.Find(s => s.Id == id);
            existingEntity.Name = entity.Name;
            existingEntity.Age = entity.Age;
            existingEntity.Surname = entity.Surname;
            existingEntity.CourseGroup = entity.CourseGroup;
        }
    }
}
