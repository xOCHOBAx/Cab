using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetCab.Common.Models;
using GetCab.DALContracts;

namespace GetCab.DatabaseDAL
{
    public class DAO : IDAO
    {
        ApplicationDbContext context;

        public DAO()
        {
            context = new ApplicationDbContext()
            {
                
            }           ;
        }


        public bool Add()
        {
            throw new NotImplementedException();
        }

    }
}
