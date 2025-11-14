using Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student : BaseEntity
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public CourseGroup CourseGroup { get; set; }

        public static int _id = 1;
        public Student()
        {
            Id = _id;
            _id++;
        }

    }
}
