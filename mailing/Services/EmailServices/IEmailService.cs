using mailing.Models;

namespace mailing.Services.EmailServices
{
    public interface IEmailService
    {
        void sendEmail(EmailDto request);
    }
}
