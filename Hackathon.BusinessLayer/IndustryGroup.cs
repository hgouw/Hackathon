﻿using System;
using System.ComponentModel.DataAnnotations;
using Hackathon.Common;

namespace Hackathon.BusinessLayer
{
    public class IndustryGroup : EntityBase, ILoggable, IEquatable<EndOfDay>
    {
        public IndustryGroup()
        {
        }

        public IndustryGroup(string group)
        {
            Group = group;
        }

        [Key]
        public virtual string Group { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"{Group}";

        public string Log() => $"Group: {Group}";

        public bool Equals(EndOfDay other)
        {
            throw new NotImplementedException();
        }
    }
}