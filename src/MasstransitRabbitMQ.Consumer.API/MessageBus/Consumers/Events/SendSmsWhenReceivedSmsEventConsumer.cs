using MasstransitRabbitMQ.Consumer.API.Abtractions.Messages;
using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.MessageBus.Consumers.Events
{
    public class SendSmsWhenReceivedSmsEventConsumer : Consumer<DomainEvent.SmsNotificationEvent>
    {
        public SendSmsWhenReceivedSmsEventConsumer(ISender sender) : base(sender)
        {
        }
    }
}
