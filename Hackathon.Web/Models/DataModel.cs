using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Web.Models
{
    public class DataModel
    {
        public List<DataView> DataViewList { get; set; }
        public class DataView
        {
            public string Id { get; set; }
            public string S3Key { get; set; }
            public string S3UserKey { get; set; }
            public string S3DateKey { get; set; }
            public bool IsFake { get; set; }
            public bool IsViolent { get; set; }
            public string Tags { get; set; }
            public string When { get; set; }
            public DateTime DateCreated { get; set; }
        }
    }
}