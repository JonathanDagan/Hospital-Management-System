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

        // TODO: fix this mess
        private double _calcRanksRateFactor()
        {
            double rateFactor = 1;
            foreach (var rank in ranks)
            {
                switch (rank)
                {
                    case ERank.junior:
                        break;
                    case ERank.senior:
                        rateFactor += 0.05;
                        break;
                    case ERank.specialist:
                        rateFactor += 0.3;
                        break;
                    case ERank.decisionMaker:
                        rateFactor += 0.5;
                        break;
                    case ERank.manager:
                        rateFactor += 0.5;
                        break;
                    default:
                        throw new Exception("IDK");
                }
            }
            return rateFactor;
        }

    }
    
}
