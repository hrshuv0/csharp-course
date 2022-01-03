using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class MembershipService
    {
        private ArrayList _members;

        public MembershipService()
        {
            _members = new ArrayList();
            _members.Add(new { Username = "jalaluddin", Password = "1234" });
            _members.Add(new { Username = "tareq", Password = "4934" });
            _members.Add(new { Username = "hasan", Password = "8493" });
            _members.Add(new { Username = "masud", Password = "8489" });
            _members.Add(new { Username = "rabbi", Password = "34325" });
        }

        public object[] GetMembers(int count)
        {
            object[] members = new object[count];
            for (int i = 0; i < _members?.Count; i++)
            {
                members[i] = _members[i];
            }

            return members;
        }
    }
}
