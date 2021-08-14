using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DalDonation
{
    public class DonationDal : IDalDonation
    {
        List<object> allDonate = new List<object>() { "sari", "dina" };
        public async Task<List<Donation>> getAllDonate()
        {
            try
            {
                using (var db = new DonationContext())
                {
                    return db.donation.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> insertDonation(Donation donationElement)
        {
            try
            {
                using (var db = new DonationContext())
                {
                    db.donation.Add(donationElement);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }
        public async Task<bool> updateDonation(Donation donationElement)
        {
            try
            {
                using (var db = new DonationContext())
                {
                    var currentDonationElement = db.donation.Where(x => x.DonationId == donationElement.DonationId).FirstOrDefault();
                    if (currentDonationElement != null)
                    {
                        currentDonationElement.YeshutName = donationElement.YeshutName;
                        currentDonationElement.CountDonation = donationElement.CountDonation;
                        currentDonationElement.CodeSugYeshut = donationElement.CodeSugYeshut;
                        currentDonationElement.ReasonDonation = donationElement.ReasonDonation;
                        currentDonationElement.ConditionDonation = donationElement.YeshutName;
                        currentDonationElement.CodeSugCurrency = donationElement.CodeSugCurrency;
                        currentDonationElement.ConversionRate = donationElement.ConversionRate;

                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false; throw;
            }
            throw new NotImplementedException();
        }
        public async Task<bool> deleteDonation(Donation donationElement)
        {
            try
            {
                using (var db = new DonationContext())
                {
                    var currentDonationElement = db.donation.Where(x => x.DonationId == donationElement.DonationId).FirstOrDefault();
                    if (currentDonationElement != null)
                    {
                        db.Entry(currentDonationElement).State = EntityState.Deleted;

                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
