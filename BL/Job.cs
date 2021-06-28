using System;
using System.Collections.Generic;

namespace BL
{
    public class Job
    {
        public string title { get; set; }
        public string description { get; set; }
        public double marketRate { get; set; }
        public HashSet<ERank> ranks { get; set; }
        public double riskFactor { get; set; }

    }
}
