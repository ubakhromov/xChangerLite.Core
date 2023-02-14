//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;

namespace xChangerLite.Core.Brokers.Queues
{
    public partial class QueueBroker : IQueueBroker
    {
        private readonly IConfiguration configuration;

        public QueueBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            InitializeClients();
        }

        private void InitializeClients()
        {         
            this.ExternalPersonQueue = GetQueueClient(nameof(ExternalPersonQueue));
        }

        private IQueueClient GetQueueClient(string queueName)
        {
            string queueConnectionString =
                this.configuration.GetConnectionString("ServiceBusConnection");

            return new QueueClient(queueConnectionString, queueName);
        }
    }
}
