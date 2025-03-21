using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.UseCases.Events
{
    public class SendSmsEventConsumerHandler : IRequestHandler<DomainEvent.SmsNotificationEvent>
    {
        private readonly ILogger _logger;

        public SendSmsEventConsumerHandler(ILogger<SendSmsEventConsumerHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(DomainEvent.SmsNotificationEvent request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Received SMS event: {request}");
        }
    }
}
