using System;

namespace Hackathon.BusinessLayer
{
    public class Data
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