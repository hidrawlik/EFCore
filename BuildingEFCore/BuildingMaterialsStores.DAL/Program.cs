using System;
using BuildingMaterialsStores.DAL.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BuildingMaterialsStores.DAL
{
    public class Program
    {
        public static void Main()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

            Console.WriteLine("ResultString: " +
                configuration.GetConnectionString("DefaultConnection") +
                Environment.NewLine +
                AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
