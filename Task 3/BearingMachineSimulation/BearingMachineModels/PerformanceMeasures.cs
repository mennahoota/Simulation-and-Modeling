using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {

        }

        public decimal BearingCost { get; set; }
        public decimal DelayCost { get; set; }
        public decimal DowntimeCost { get; set; }
        public decimal RepairPersonCost { get; set; }
        public decimal TotalCost { get; set; }

        public void CalculateBearingCost(decimal numBearing, decimal costBaring)
        {
            BearingCost = numBearing * costBaring;
        }

        public void CalculateDelayCost(decimal totalDelay, decimal delayPerMinute)
        {
            DelayCost = totalDelay * delayPerMinute;
        }

        public void CalculateDowntimeCost(int changedBearing, decimal repairBearing, decimal delayPerMinute)
        {
            DowntimeCost = changedBearing * repairBearing * delayPerMinute;
        }

        public void CalculateRepairPersonCost(int changedBearing, decimal repairBearing, decimal costPerRepairPerson)
        {
            RepairPersonCost = changedBearing * repairBearing * (costPerRepairPerson / 60);
        }

        public void CalculateTotalCost()
        {
            TotalCost = this.BearingCost + this.DelayCost + this.DowntimeCost + this.RepairPersonCost;
        }
    }
}
