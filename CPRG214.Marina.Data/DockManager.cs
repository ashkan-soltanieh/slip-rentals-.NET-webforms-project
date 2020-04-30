using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class DockManager
    {
        public System.Collections.IList GetAllDocks()
        {
            MarinaEntities db = new MarinaEntities();
            var docks = db.Docks.Select(dock => new
            {
                ID = dock.ID,
                Name = dock.Name
            }).ToList();
            return docks;
        }
    }
}
