using Microsoft.AspNetCore.Mvc;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Services;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Controllers
{
    [Route("api/[controller]")]
    public class BonusPoolController : Controller
    {
        public BonusPoolController(IBonusPoolService bonusPoolService)
        {
            this._bonusPoolService = bonusPoolService;
        }

        private IBonusPoolService _bonusPoolService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
                return Ok(await _bonusPoolService.GetEmployeesAsync());
        }

        [HttpPost()]
        public async Task<IActionResult> CalculateBonus([FromBody] CalculateBonusDto request)
        {
            var employee = await _bonusPoolService.CalculateAsync(
                request.TotalBonusPoolAmount,
                request.SelectedEmployeeId);

            if(employee.Employee == null)
            {
                return BadRequest($"Bad Request : Employee Id is not Found");

            }

            return Ok(employee);

        }
    }
}
