using MassTransit;
using MasstransitRabbitMQ.Contract.Constants;
using Microsoft.AspNetCore.Mvc;
using static MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents.DomainEvent;

namespace MasstransitRabbitMQ.Producer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public ProducersController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost("PublishSmsNotificationEvent")]
        public async Task<IActionResult> PublishSmsNotificationEvent()
        {
            await _publishEndpoint.Publish(new SmsNotificationEvent
            {
                Id = Guid.NewGuid(),
                TimeStamp = DateTimeOffset.UtcNow,
                Name = "Sms Notification",
                Description = "This is a sms notification",
                Type = NotificationType.SMS,
                TransactionId = Guid.NewGuid()
            });
            return Accepted();
        }

        [HttpPost("PublishEmailNotificationEvent")]
        public async Task<IActionResult> PublishEmailNotificationEvent()
        {
            await _publishEndpoint.Publish(new EmailNotificationEvent
            {
                Id = Guid.NewGuid(),
                TimeStamp = DateTimeOffset.UtcNow,
                Name = "Email Notification",
                Description = "This is a email notification",
                Type = NotificationType.EMAIL,
                TransactionId = Guid.NewGuid()
            });
            return Accepted();
        }
    }
}
