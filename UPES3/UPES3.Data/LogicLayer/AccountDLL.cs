using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES3.Data.Access;

namespace UPES3.Data.LogicLayer
{
   public class AccountDLL
    {
        DataContext context;
        public AccountDLL()
        {
            context = new DataContext();
        }
        public lecturer getInfo(string user)
        {
            return context.lecturers.Where(x => x.userName == user).FirstOrDefault();
        }
        public int changePassword(string user,string nPass)
        {
            try
            {
                account account = context.accounts.Find(user);
                account.passWord = nPass;
                context.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public bool findAccount(string user, string pass)
        {
            try
            {
                context.accounts.Where(x => x.userName == user && x.passWord == pass);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int updateInfo(lecturer model, string user)
       
        {
            lecturer lecturer = context.lecturers.Where(x => x.userName == user).FirstOrDefault();
            lecturer.idLecturer = model.idLecturer;
            lecturer.idDepartment = model.idDepartment;
            lecturer.name = model.name;
            lecturer.phone = model.phone;
            lecturer.email = model.email;
            try
            {
                context.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
          
        }
    }
}
