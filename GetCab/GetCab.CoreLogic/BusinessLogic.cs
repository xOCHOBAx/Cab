using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetCab.BusinessLogicContracts;

namespace GetCab.CoreLogic
{
    public class BusinessLogic : IBusinessLogic
    {
        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool CanAuthenticate()
        {
            return true;
        }

        public string[] GetRolesForUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
