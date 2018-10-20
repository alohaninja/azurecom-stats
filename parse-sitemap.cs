using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Sitemap
{
    public static class ParseSitemap
    {
        [FunctionName("parse-sitemap")]
        public static void Run([TimerTrigger("0 */2 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}