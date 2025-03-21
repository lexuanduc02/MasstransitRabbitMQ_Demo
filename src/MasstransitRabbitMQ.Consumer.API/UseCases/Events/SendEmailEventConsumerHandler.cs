using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.UseCases.Events
{
    public class SendEmailEventConsumerHandler : IRequestHandler<DomainEvent.EmailNotificationEvent>
    {
        private readonly ILogger _logger;

        public SendEmailEventConsumerHandler(ILogger<SendEmailEventConsumerHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(DomainEvent.EmailNotificationEvent request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Received Email event: {request}");
        }
    }
}
