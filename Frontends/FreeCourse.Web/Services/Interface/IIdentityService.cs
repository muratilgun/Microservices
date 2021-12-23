using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using IdentityModel.Client;

namespace FreeCourse.Web.Services.Interface
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn();
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task RevokeRefreshToken();
    }
}
