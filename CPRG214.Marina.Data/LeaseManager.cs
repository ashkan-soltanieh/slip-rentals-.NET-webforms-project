using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class LeaseManager
    {
        public static void MakeAndAddLease(int slipId, int customerId)
        {
            MarinaEntities db = new MarinaEntities();
            Lease lease = new Lease
            {
                SlipID = slipId,
                CustomerID = customerId
            };
            db.Leases.Add(lease);
            db.SaveChanges();
        }

        public static System.Collections.IList GetAllLease(int customerId)
        {
            MarinaEntities db = new MarinaEntities();
            var leases = db.Leases.Where(lease =>
                    (lease.CustomerID == customerId)).ToList();
            return leases;
        }
        //public static IList<LeaseDTO> PotentialLeases(string slipId, int customerId)
        //{

        //    LeaseDTO potentialLease = new LeaseDTO();
        //    potentialLease.SlipID = int.Parse(slipId);
        //    potentialLease.CustomerID = customerId;
        //    potentialLeases.Add(potentialLease);
        //    return potentialLeases;
        //}


    }
}
