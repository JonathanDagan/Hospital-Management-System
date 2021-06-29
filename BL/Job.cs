using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class Job
    {
        public string title { get; set; }
        public string description { get; set; }
        public double marketRate { get; set; }
        public HashSet<ERank> ranks { get; set; }

        public double riskFactor { get; set; }
        // TODO: load from config
        private Dictionary<ERank, double> _rankToRate = new Dictionary<ERank, double>(){
            {ERank.junior, 0},
            {ERank.senior, 0.05},
            {ERank.senior, 0.3},
            {ERank.decisionMaker, 0.5},
            {ERank.manager, 0.5},
        };
        public double getHourlyRate()
        {
            double rate = marketRate;

            if (riskFactor > 0)
            {
                rate *= ( 1 + riskFactor );
            }

            rate += _calcRanksRateFactor();
            
            return rate;
        }

        private double _calcRanksRateFactor()
        {
            return 1 + ranks.Sum(rank => _rankToRate[rank]);
        }

    }
    
}
