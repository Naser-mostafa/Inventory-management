using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UhlSportDataAccessLayer
{
    public class GlobalCurrentUser
    {
        public BigInteger UserId;
            public sbyte  PermissionNumber = 0;
            public string FirstName, LastName, UserName, Password;
    }
}
