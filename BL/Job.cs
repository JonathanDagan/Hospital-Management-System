using System;
using System.Collections.Generic;
using System.Linq;

using DAL;

namespace BL
{
    public class Job
    {
        public string title { get; set; }
        public string description { get; set; }
        public double marketRate { get; set; }
        public HashSet<ERank> ranks { get; set; }

        public double riskFactor { get; set; }
        public Job(string title, string description, double marketRate, HashSet<ERank> ranks, double riskFactor = 0)
        {
            this.title = title;
            this.description = description;
            this.marketRate = marketRate;
            this.ranks = ranks;
            this.riskFactor = riskFactor;
        }
        // TODO: load from config
        private Dictionary<ERank, double> _rankToRate = new Dictionary<ERank, double>(){
            {ERank.junior, RankFactors.junior},
            {ERank.senior, RankFactors.senior},
            {ERank.specialist, RankFactors.specialist},
            {ERank.decisionMaker, RankFactors.decisionMaker},
            {ERank.manager, RankFactors.manager},
        };
        public double GetHourlyRate()
        {
            double rate = marketRate;

            if (riskFactor > 0)
            {
                rate *= ( 1 + riskFactor );
            }

            return rate += _CalcRanksRateFactor();
        }

        private double _CalcRanksRateFactor()
        {
            return 1 + ranks.Sum(rank => _rankToRate[rank]);
        }

    }
    
}
