using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseCreateDto
    {
        string Name { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        string Picture { get; set; }

        string UserId { get; set; }
        FeatureDto Feature { get; set; }
        string CategoryId { get; set; }
    }
}
