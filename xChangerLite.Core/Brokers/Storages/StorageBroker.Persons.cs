//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using Microsoft.EntityFrameworkCore;
using xChangerLite.Core.Models.Foundations.Persons;

namespace xChangerLite.Core.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Person> Persons { get; set; }
    }
}
