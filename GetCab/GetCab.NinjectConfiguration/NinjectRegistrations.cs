using GetCab.BusinessLogicContracts;
using GetCab.Common.Models;
using GetCab.CoreLogic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetCab.NinjectConfiguration
{

    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IBusinessLogic>().To<BusinessLogic>();
            Bind<IUserStore<ApplicationUser>>().To<UserStore<ApplicationUser>>();
            Bind<IAuthenticationManager>().To<>();
        }

    }

}

