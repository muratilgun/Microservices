using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FreeCourse.Web.Models;
using FreeCourse.Web.Models.Catalogs;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{

    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;

        public CatalogService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<CourseViewModel>> GetAllCourseAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryViewModel>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CourseViewModel> GetAllCourseByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<CourseViewModel> GetByCourseIdAsync(string courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateCourseAsync(CourseCreateInput courseCreateInput)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCourseAsync(CourseUpdateInput courseUpdateInput)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCourseAsync(string courseId)
        {
            throw new NotImplementedException();
        }
    }
}
