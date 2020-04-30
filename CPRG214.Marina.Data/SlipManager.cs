using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class SlipManager
    {
        public static System.Collections.IList GetAvailableSlipsbyDockID(int selectedDockID)
        {
            //var leases = LeaseManager.GetAllSlipIDFromLeases();
            MarinaEntities db = new MarinaEntities();
            var availableSlips = db.Slips.Where(slip =>
                (slip.Leases.Count == 0 && slip.DockID == selectedDockID)
            ).ToList();
            return availableSlips;
        }

    }
}
