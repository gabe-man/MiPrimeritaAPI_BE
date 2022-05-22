using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Implementations
{
    public class UserDAL : IUserDAL
    {
        public IESContext Context { get; set; }

        public UserDAL(IESContext context)
        {
            this.Context = context;
        }

        public void Register(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }

        public bool CheckUserLogin(string name, string password)
        {
            var User = Context.Users.FirstOrDefault(u => (u.Name == name && u.Password == password));
            if (User != null)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUserRegister(User user)
        {
            var User = Context.Users.FirstOrDefault(u => (u.Name == user.Name || u.Email == user.Email));
            if (User != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
