//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using System.Collections.Generic;
using System.Text.Json.Serialization;
using System;
using xChangerLite.Core.Models.Foundations.Pets;

namespace xChangerLite.Core.Models.Foundations.Persons
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [JsonIgnore]
        public List<Pet> Pets { get; set; }
    }
}
