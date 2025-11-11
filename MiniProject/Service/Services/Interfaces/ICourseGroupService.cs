using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ICourseGroupService
    {
        void Create(CourseGroup courseGroup);
        void Update(int id, CourseGroup courseGroup);
        void Delete(int id);
        CourseGroup GetById(int id);
        List<CourseGroup> GetAll();
        List<CourseGroup> GetAllByTeacherName(string teacherName);
        List<CourseGroup> GetAllByRoom(string room);
        List<CourseGroup> SearchByName(string name);
    }
}
