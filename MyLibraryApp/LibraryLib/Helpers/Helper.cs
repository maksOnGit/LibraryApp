using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Helpers
{
    public static class Helper
    {
        public static int CalculateId<T>(List<T> list)
        {
            object o = null;
      

            if (list.Count == 0)
            {
                return 1;
            }
            else
            {
                o = list.Last();
                BaseModel b = (BaseModel)o;

                return b.Id + 1;
            }
             
        }
    }
}
