using FreeCourse.Services.Catalog.Model;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseDto
    {

        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        string UserId { get; set; }
        string Picture { get; set; }
        DateTime CreatedTime { get; set; }
        FeatureDto Feature { get; set; }
        string CategoryId { get; set; }
        CategoryDto Category { get; set; }
    }
}
