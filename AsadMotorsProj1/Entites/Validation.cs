using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AsadMotorsProj1.Entites
{
    class Validation
    {
        public bool MemberValidation(string MPhone , string MName)
        {
            SQLHelpers sQLHelpers = new SQLHelpers();
            if (sQLHelpers.GetMembersInfo(MPhone, MName) != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
