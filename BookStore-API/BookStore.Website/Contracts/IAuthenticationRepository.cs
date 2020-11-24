﻿using BookStore.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Website.Contracts
{
    public interface IAuthenticationRepository
    {
        Task<bool> Register(UserRegistrationModel user);

        Task<bool> Login(UserLoginModel user);

        Task LogOut();
    }
}
