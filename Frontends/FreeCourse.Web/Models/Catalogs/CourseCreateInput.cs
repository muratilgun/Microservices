﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name = "Kurs İsmi")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Kurs Açıklama")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "Kurs Fiyat")]
        [Required]

        public decimal Price { get; set; }
        public string Picture { get; set; }

        public string UserId { get; set; }
        public FeatureViewModel Feature { get; set; }
        [Display(Name = "Kurs Kategori")]
        [Required]
        public string CategoryId { get; set; }
        [Display(Name = "Kurs Resim")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
