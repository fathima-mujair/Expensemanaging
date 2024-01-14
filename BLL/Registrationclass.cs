using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Registrationclass
    {
        Connectionclass objdal = new Connectionclass();

        public int Fn_insert(string na, string email, string pw)
        {
            string strins = "insert into users values('" + na + "','" + email + "','" + pw + "')";
            int i = objdal.Fn_Nonquery(strins);
            return i;
        }
    }
}
