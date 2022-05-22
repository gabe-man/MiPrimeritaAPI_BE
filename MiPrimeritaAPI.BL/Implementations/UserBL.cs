using AutoMapper;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.CORE.DTO;
using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.BL.Implementations
{
    public class UserBL : IUserBL
    {
        public IUserDAL userDAL { get; set; }
        public IMapper  mapper { get; set; }

        public UserBL(IUserDAL userDAL, IMapper mapper)
        {
            this.userDAL = userDAL;
            this.mapper = mapper;
        }

        public void Register(UserDTO user)
        {
            var usuario = mapper.Map<User>(user);
            userDAL.Register(usuario);
        }

        public bool CheckUserLogin(LoginDTO login)
        {
            return userDAL.CheckUserLogin(login.Name, login.Password);
        }

        public bool CheckUserRegister(UserDTO user)
        {
            var usuario = mapper.Map<User>(user);
            return userDAL.CheckUserRegister(usuario);
        }
    }
}
