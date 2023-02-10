//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace xChangerLite.Core.Brokers.Sheets
{
    public partial class SheetBroker : ISheetBroker, IDisposable
    {
        private readonly IConfiguration configuration;

        public SheetBroker(IConfiguration configuration) =>
            this.configuration = configuration;

        public void Dispose() { }

        private string GetSheetLocationWithName() =>
            this.configuration.GetConnectionString("SheetConnection");

        private FileInfo GetFileInfo() =>
            new FileInfo(fileName: GetSheetLocationWithName());
    }
}
