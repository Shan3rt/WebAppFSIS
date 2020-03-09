using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSISSystem.DAL;
using FSISSystem.ENTITIES;

namespace FSISSystem.BLL
{
    class GuardianController
    {
        public Guardian Guardians_FindByID(int guardianid)
        {
            using (var context = new FSISContext())
            {
                return context.Guardians.Find(guardianid);
            }
        }
    }
}
