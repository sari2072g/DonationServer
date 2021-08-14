using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DalDonation
{
    public interface IDalDonation
    {
        Task<List<Donation>> getAllDonate();
        Task<bool> insertDonation(Donation donationElement);
        Task<bool> updateDonation(Donation donationElement);
        Task<bool> deleteDonation(Donation donationElement);
    }
}
