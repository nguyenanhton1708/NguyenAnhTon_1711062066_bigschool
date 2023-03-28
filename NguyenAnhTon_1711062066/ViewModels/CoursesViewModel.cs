using NguyenAnhTon_1711062066.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenAnhTon_1711062066.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}