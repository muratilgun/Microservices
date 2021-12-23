using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using IdentityModel.Client;

namespace FreeCourse.Web.Services.Interface
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SigninInput input);
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task RevokeRefreshToken();
    }
}
