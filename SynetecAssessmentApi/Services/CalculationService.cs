using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal CalculateBonusPercentage(decimal salary, decimal totalSalary)
        {
            decimal salaryNeeded = (totalSalary * (decimal)0.15);

            if (salaryNeeded <= salary)
            {
                return (decimal)0.15;
            }

            return (decimal)0;
        }

        public int CalculateBonusAllocation(decimal bonusPercentage, decimal bonusPoolAmount)
        {
            return (int)(bonusPercentage * bonusPoolAmount);
        }
    }
}
