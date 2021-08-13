using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES3.Data.Access;

namespace UPES3.Data.LogicLayer
{
    public class NotificationDLL
    {
        DataContext context ;
        public NotificationDLL()
        {
            context = new DataContext();
        }
        public List<notification> getListNotifications()
        {          
            return context.notifications.ToList();
        }
        public notification getDetailNotification(int id)
        {
            return context.notifications.Where(x => x.idNotification == id).FirstOrDefault();
        }
        public int addNotification(notification data)
        {
            try
            {
                context.notifications.Add(data);
                context.SaveChanges();
                return 1;
            }
            catch(Exception e)
            {
                return -1;
            }
        }
        public int deleteNotification(int id)
        {
            try
            {
                notification data = context.notifications.Find(id);
                context.notifications.Remove(data);
                context.SaveChanges();
                return 1;
            }
            catch(Exception e)
            {
                return -1;
            }
        }
        public int editNotification(notification data)
        {
            try
            {
                notification item = context.notifications.Find(data.idNotification);
                item.content = data.content;
                item.title = data.title;
                item.metaTitle = data.metaTitle;
                item.FileName = data.FileName;
                context.SaveChanges();
                return 1;
            }
            catch(Exception e)
            {
                return -1;
            }
        }
    }
}
