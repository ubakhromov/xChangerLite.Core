//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using System;

namespace xChangerLite.Core.Models.Foundations.Pets
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }

        public Guid PersonId { get; set; }
    }
}
