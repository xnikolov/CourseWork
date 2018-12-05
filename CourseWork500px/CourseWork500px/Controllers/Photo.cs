﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork500px
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string CameraModel { get; set; }
    }
}