using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES3.Data.Access;

namespace UPES3.Data.LogicLayer
{
    public class ClassityDLL
    {
        DataContext context;
        public ClassityDLL()
        {
            context = new DataContext();
        }
        public List<classityType> getClasssity()
        {
            return context.classityTypes.ToList();
        }
    }
}
