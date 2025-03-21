using MasstransitRabbitMQ.Consumer.API.Abtractions.Messages;
using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.MessageBus.Consumers.Events
{
    public class SendMailWhenReceivedEmailEventConsumer : Consumer<DomainEvent.EmailNotificationEvent>
    {
        public SendMailWhenReceivedEmailEventConsumer(ISender sender) : base(sender)
        {
        }
    }
}
