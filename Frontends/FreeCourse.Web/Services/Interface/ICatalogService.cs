using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models.Catalogs;

namespace FreeCourse.Web.Services.Interface
{
    public interface ICatalogService
    {
        Task<List<CourseViewModel>> GetAllCourseAsync();
        Task<List<CategoryViewModel>> GetAllCategoryAsync();
        Task<CourseViewModel> GetAllCourseByUserIdAsync(string userId);
        Task<CourseViewModel> GetByCourseIdAsync(string courseId);
        Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput);
        Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput);
        Task<bool> DeleteCourseAsync(string courseId);

    }
}
