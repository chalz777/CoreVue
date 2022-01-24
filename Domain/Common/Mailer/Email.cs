using Core.Global;
using Microsoft.Extensions.Options;
//using KIT.Services;
using KDT.Utilities.EmailService;


namespace Core.Common.Mailer
{
    public class Email
    {
        private readonly EmailService _emailService;
        private readonly IOptions<Globals> _appSettings;

        public Email(EmailService emailService, IOptions<Globals> appSettings)
        {
            _emailService = emailService;
            _appSettings = appSettings;
        }
    }
}
