using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES3.Data.Access;

namespace UPES3.Data.LogicLayer
{
    public class AdminDLL
    {
        DataContext context;
        public AdminDLL()
        {
            context = new DataContext();
        }
        public IEnumerable<account> getListAccount(string seach, int page, int pagesize)
        {
            IQueryable<account> res = context.accounts;
            if (!string.IsNullOrEmpty(seach))
            {
                res = res.Where(x => x.userName.Contains(seach));
            }
            return res.OrderBy(x => x.userName).ToPagedList(page, pagesize);
        }
        public int addAccount(account model)
        {
            model.passWord = HashMD5.MD5Hash(model.passWord);
            try
            {
                var res = context.accounts.Add(model);
                context.SaveChanges();
                return 1;
            }
            catch (Exception error)
            {              
                return -1;
            }
        }
        public account getDetail(string user)
        {
            return context.accounts.Where(x => x.userName == user).SingleOrDefault();
        }
        public lecturer Check(string user)
        {
            return context.lecturers.Where(x => x.userName == user).SingleOrDefault();
        }
    }
}
