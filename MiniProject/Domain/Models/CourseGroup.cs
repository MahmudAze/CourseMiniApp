using Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CourseGroup : BaseEntity
    {
        public string TeacherName { get; set; }
        public string Room { get; set; }

        public static int _id;
        public CourseGroup()
        {
            Id = _id;
            _id++;
        }
    }
}
