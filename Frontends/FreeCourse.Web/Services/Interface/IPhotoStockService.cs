using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Services.Interface
{
    public interface IPhotoStockService
    {
        Task<string> UploadPhoto(IFormFile photo);
    }
}
