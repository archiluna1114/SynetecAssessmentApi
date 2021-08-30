namespace SynetecAssessmentApi.Services
{
    public interface ICalculationService
    {
        int CalculateBonusAllocation(decimal bonusPercentage, decimal bonusPoolAmount);
        decimal CalculateBonusPercentage(decimal salary, decimal totalSalary);
    }
}