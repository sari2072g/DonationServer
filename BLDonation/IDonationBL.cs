using DalDonation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLDonation
{
   public interface IDonationBL
    {
       Task<List<Donation>> getAllDonation();
        Task<bool> insertDonation(Donation donationElement);
        Task<bool> updateDonation(Donation donationElement);
        Task<bool> deleteDonation(Donation donationElement);
    }
}
