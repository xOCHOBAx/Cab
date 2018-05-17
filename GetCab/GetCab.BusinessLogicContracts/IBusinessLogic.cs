using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCab.BusinessLogicContracts
{
    public interface IBusinessLogic
    {
        bool CanAuthenticate();
        bool Add();
        string[] GetRolesForUser(string username);
    }
}
