﻿using R.MessageBus.Interfaces;

namespace R.Scheduler.Interfaces
{
    public interface IConfiguration
    {
        PersistanceStoreType PersistanceStoreType { get; set; }
        string ConnectionString { get; set; }
        string TablePrefix { get; set; }
        string InstanceName { get; set; }
        string InstanceId { get; set; }
        string UseProperties { get; set; }

        bool EnableMessageBusSelfHost { get; set; }
        bool EnableWebApiSelfHost { get; set; }
        string WebApiBaseAddress { get; set; }

        ITransportSettings TransportSettings { get; set; }
    }
}
