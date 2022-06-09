using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace xPatreonFunctionApp
{
    public class Function1
    {
        private IUserService _userService;

        public Function1(IUserService userService)
        {
            _userService = userService;
        }

        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
        {
            var s = _userService.ListOfContentsForTimer();

            if (s != null)
            {
                foreach (var item in s)
                {
                    int result = DateTime.Compare(item.PublicationData, DateTime.UtcNow);
                    if (result < 0)
                    {
                        _userService.ActiveContentForTimer(item.Content_ID);
                        log.LogInformation($"The post {0} as been activated", item.Title);
                    }
                    else
                    {
                        log.LogInformation($"date didnt match...");
                    }
                }
            }
            else
            {
                log.LogInformation($"No items in the list...");
            }
        }
    }
}
