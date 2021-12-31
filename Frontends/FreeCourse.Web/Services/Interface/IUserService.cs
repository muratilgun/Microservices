using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models;

namespace FreeCourse.Web.Services.Interface
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}
