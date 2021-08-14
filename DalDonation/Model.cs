
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DalDonation
{
    public class DonationContext : DbContext
    {
        public DbSet<Donation> donation { get; set; }
        public DbSet<Currency> currency { get; set; }
        public DbSet<SugYeshut> sugYeshut { get; set; }


        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\Users\user\Desktop\Donation\DonationWebAPI\DalDonation\donationDB\Donation.db"); 
    }

    public class Donation
    {
        public int DonationId { get; set; }
        public string YeshutName { get; set; }
        public float CountDonation { get; set; }
        public int CodeSugYeshut { get; set; }
        public string ReasonDonation { get; set; }
        public string ConditionDonation { get; set; }
        public int? CodeSugCurrency { get; set; }
        public float? ConversionRate { get; set; }


    }

    public class Currency
    {
        public int Id { get; set; }
        public string DescriptionCurrency { get; set; }
    }
    public class SugYeshut
    {
        public int Id { get; set; }
        public string DescriptionYeshut { get; set; }
    }
}
