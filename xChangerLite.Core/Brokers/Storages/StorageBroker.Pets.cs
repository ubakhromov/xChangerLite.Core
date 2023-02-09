//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using Microsoft.EntityFrameworkCore;
using xChangerLite.Core.Models.Foundations.Pets;

namespace xChangerLite.Core.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Pet> Pets { get; set; }
    }
}
