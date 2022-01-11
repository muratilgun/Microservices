using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models.PhotoStocks;
using FreeCourse.Web.Services.Interface;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Services
{
    public class PhotoStockService : IPhotoStockService
    {
        public async Task<PhotoViewModel> UploadPhoto(IFormFile photo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePhoto(string photoUrl)
        {
            throw new NotImplementedException();
        }
    }
}
