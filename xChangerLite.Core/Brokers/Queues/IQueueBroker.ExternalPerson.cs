//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace xChangerLite.Core.Brokers.Queues
{
    public partial interface IQueueBroker
    {
        public ValueTask EnqueueExternalPersonEventMessageAsync(Message message);
    }
}
