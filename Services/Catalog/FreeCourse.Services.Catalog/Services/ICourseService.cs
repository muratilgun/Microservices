using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
   public interface ICourseService
    {
       public Task<Response<List<CourseDto>>> GetAllAsync();
        public Task<Response<CourseDto>> GetByIdAsync(string id);
        public Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string userId);
        public Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        public Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        public Task<Response<NoContent>> DeleteAsync(string id);


    }
}
