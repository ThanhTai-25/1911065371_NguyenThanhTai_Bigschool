﻿using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1911065371_NguyenThanhTai_Bigschool.Models
{
    public class Course
    {
        public bool IsCanceled { get; set; }
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }

        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}