using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class HelperFunctions
    {
        public static void CalcCummulativeProbability(ref List<TimeDistribution> TimeDistributions)
        {
            for (int i = 0; i < TimeDistributions.Count(); i++)
            {
                if (i == 0)
                    TimeDistributions[i].CummProbability = TimeDistributions[i].Probability;
                else
                {
                    TimeDistributions[i].CummProbability = TimeDistributions[i - 1].CummProbability + TimeDistributions[i].Probability;
                }
            }

        }
        public static void CalcRandomDigitAssignment( ref List<TimeDistribution> TimeDistributions)
        {
            for (int i=0; i<TimeDistributions.Count(); i++)
            {
                if (i==0)
                {
                    TimeDistributions[i].MinRange = 1;
                    TimeDistributions[i].MaxRange = Decimal.ToInt32(TimeDistributions[i].CummProbability) * 100;
                }
                else
                {
                    TimeDistributions[i].MinRange = TimeDistributions[i - 1].MaxRange + 1;
                    TimeDistributions[i].MaxRange = Decimal.ToInt32(TimeDistributions[i].CummProbability) * 100;
                }
            }
        }

    }
}
