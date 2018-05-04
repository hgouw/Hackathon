﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hackathon.Common;

namespace Hackathon.BusinessLayer
{
    public class Company : EntityBase, ILoggable, IEquatable<Company>
    {
        public Company()
        {
        }

        public Company(string code, string name, string group)
        {
            Code = code;
            Name = name;
            Group = group;
        }

        [Key]
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        [ForeignKey("IndustryGroup")]
        public virtual string Group { get; set; }

        public virtual IndustryGroup IndustryGroup { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"{Code} - {Name} - {Group}";

        public string Log() => $"{Code} - {Name} - {Group}";

        public bool Equals(Company other)
        {
            throw new NotImplementedException();
        }
    }
}