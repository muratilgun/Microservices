﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interface
{
    public interface IClientCredentialTokenService
    {
        Task<string> GetToken();
    }
}
