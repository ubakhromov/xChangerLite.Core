//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================


using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace xChangerLite.Core.Brokers.Queues
{
    public partial class QueueBroker
    {
        public IQueueClient ExternalPersonQueue { get; set; }

        public async ValueTask EnqueueExternalPersonEventMessageAsync(Message message) =>
            await this.ExternalPersonQueue.SendAsync(message);
    }
}
