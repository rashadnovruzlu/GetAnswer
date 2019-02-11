using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;

namespace GetAnswer.WebAPI.Services
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            await configSendGridasync(message);
        }

        // Use NuGet to install SendGrid (Basic C# client lib) 
        private async Task configSendGridasync(IdentityMessage message)
        {
            throw new NotImplementedException();
        }

       
    }
}