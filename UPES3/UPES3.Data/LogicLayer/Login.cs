using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES3.Data.Access;


namespace UPES3.Data.LogicLayer
{
   public class Login
    {

        DataContext context;
        public Login()
        {
            context = new DataContext();
        }
        public int Signin(string username, string password)
        {
            password = HashMD5.MD5Hash(password);
            var item = context.accounts.Where(x => x.userName == username && x.passWord == password).SingleOrDefault();
            if (item != null)
            {              
                int res = int.Parse(item.status.ToString());
                return res;
            }
            else
                return -1;

        }
        public account GetAccount(string username)
        {
            return context.accounts.Where(x => x.userName == username).SingleOrDefault();
        }
    }
}
