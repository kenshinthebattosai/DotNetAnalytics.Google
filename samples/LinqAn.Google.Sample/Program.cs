﻿using LinqAn.Google.Profiles;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinqAn.Google.Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("gasettings.json");
            var config = builder.Build();
            var viewId = Convert.ToUInt32(config["profile:view_id"]);
            var serviceAccountEmail = config["profile:service_account_email"];
            var applicationName = config["profile:application_name"];
            var keyFilePath = Directory.GetCurrentDirectory() + "\\" + config["profile:key_file_name"];

            var profile = new AnalyticsProfile(serviceAccountEmail, keyFilePath, applicationName);
            var googleAnalytics = new AnalyticsContext(profile);
            var records = googleAnalytics.Records
                // View Id
                .Where(x => x.ViewId == viewId)
                // Start Date, End Date
                .Where(x => x.RecordDate == DateTime.Today.AddDays(-1))
                // Include Dimensions
                .Include(x => x.Source)
                .Include(x => x.Medium)
                // Include Metrics
                .Include(x => x.Pageviews)
                .Include(x => x.Sessions)
                .Include(x => x.SessionDuration)
                // Filters
                .Where(x => x.Country == "India" && x.Medium == new Regex("organic"))
                .Where(x => x.Source.Contains("a") && !x.Source.Contains("x"))
                .Where(x => x.SessionDuration > TimeSpan.FromMinutes(1))
                // Sort
                .OrderByDescending(x => x.SessionDuration)
                .ThenBy(x => x.Source)
                // Skip 1 record
                .Skip(1)
                // Take only 5 records
                .Take(5);

            foreach (var record in records)
                Console.WriteLine(record.ToStringRepresentation());

            Task.Run(async () =>
            {
                var list = await records.ToListAsync();
                foreach (var item in list)
                    Console.WriteLine(item.ToStringRepresentation());
            }).Wait();

            Console.ReadLine();
        }
    }
}
