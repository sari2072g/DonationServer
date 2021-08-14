using DalDonation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLDonation
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection collection)
        {
            collection.AddScoped<IDalDonation, DonationDal>();
            return collection;
        }
    }
}
