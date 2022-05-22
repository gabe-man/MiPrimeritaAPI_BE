﻿using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Contracts
{
    public interface IUserDAL
    {
        public void Register(User user);

        public bool CheckUserLogin(string name, string password);

        public bool CheckUserRegister(User user);
    }
}
