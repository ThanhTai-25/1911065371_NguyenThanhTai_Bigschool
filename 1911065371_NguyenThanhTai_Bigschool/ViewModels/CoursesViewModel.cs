using _1911065371_NguyenThanhTai_Bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911065371_NguyenThanhTai_Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }

        public bool ShowAction { get; set; }
    }
}