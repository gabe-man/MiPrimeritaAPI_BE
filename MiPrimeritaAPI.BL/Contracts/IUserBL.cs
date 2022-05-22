using MiPrimeritaAPI.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.BL.Contracts
{
    public interface IUserBL
    {
        public void Register(UserDTO user);
        public bool CheckUserLogin(LoginDTO login);
        public bool CheckUserRegister(UserDTO user);
    }
}
