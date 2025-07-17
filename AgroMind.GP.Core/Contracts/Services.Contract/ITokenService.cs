﻿using AgroMind.GP.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace AgroMind.GP.Core.Contracts.Services.Contract
{
    public interface ITokenService
    {
        Task<string> CreateTokenAsync(AppUser user, UserManager<AppUser> userManager);

    }
}
