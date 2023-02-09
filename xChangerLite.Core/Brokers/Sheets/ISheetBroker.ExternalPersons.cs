//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using System.Collections.Generic;
using System.Threading.Tasks;
using xChangerLite.Core.Models.Foundations.ExternalPerson;

namespace xChangerLite.Core.Brokers.Sheets
{
    public partial interface ISheetBroker
    {
        ValueTask<List<ExternalPerson>> SelectAllExternalPersonsAsync();
    }
}
