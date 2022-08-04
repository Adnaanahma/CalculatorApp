using Calculator.Model.Entity;
using Calculator.Service.Implementations;
using CalculatorModel.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        /// <summary>
        ///Addition Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AdditionModel")]
        public async Task<IActionResult> Addition(AdditionModel model)
        {
            var response = await _calculatorService.Addition(model);
            return Ok(response);
        }
        /// <summary>
        ///Subtraction Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("SubtractionModel")]
        public async Task<IActionResult> Subtraction(SubtractionModel model)
        {
            var response = await _calculatorService.Subtraction(model);
            return Ok(response);
        }
        /// <summary>
        /// Division Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("DivisionModel")]
        public async Task<IActionResult> Division(DivisionModel model)
        {
            var response = await _calculatorService.Division(model);
            return Ok(response);
        }
        /// <summary>
        ///Multiplication Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("MultiplicationModel")]
        public async Task<IActionResult> Multiplication(MultiplicationModel model)
        {
            var response = await _calculatorService.Multiplication(model);
            return Ok(response);
        }
        /// <summary>
        /// Area Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AreaOfRectangleModel")]
        public async Task<IActionResult> Area(AreaOfRectangleModel model)
        {
            var response = await _calculatorService.Area(model);
            return Ok(response);
        }
        /// <summary>
        /// Volume Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("VolumeOfCubeModel")]
        public async Task<IActionResult> Volume(VolumeOfCubeModel model)
        {
            var response = await _calculatorService.Volume(model);
            return Ok(response);
        }
        /// <summary>
        /// Acceleration Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AccelerationModel")]
        public async Task<IActionResult> Acceleration(AccelerationModel model)
        {
            var response = await _calculatorService.Acceleration(model);
            return Ok(response);
        }
        /// <summary>
        /// Weight Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("WeightOfObjectModel")]
        public async Task<IActionResult> Weight(WeightOfObjectModel model)
        {
            var response = await _calculatorService.Weight(model);
            return Ok(response);
        }
        /// <summary>
        ///SquareRoot Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("SquareRootModel")]
        public async Task<IActionResult> SquareRoot(SquareRootModel model)
        {
            var response = await _calculatorService.SquareRoot(model);
            return Ok(response);
        }
        /// <summary>
        /// Exponential Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("RaiseToPowerModel")]
        public async Task<IActionResult> Exponential(RaiseToPowerModel model)
        {
            var response = await _calculatorService.Exponential(model);
            return Ok(response);
        }
        /// <summary>
        ///Density Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("DensityOfObjectModel")]
        public async Task<IActionResult> Density(DensityOfObjectModel model)
        {
            var response = await _calculatorService.Density(model);
            return Ok(response);
        }
        /// <summary>
        /// Percentage Controller
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("PercentageModel")]
        public async Task<IActionResult> Percentage(PercentageModel model)
        {
            var response = await _calculatorService.Percentage(model);
            return Ok(response);
        }
        /// <summary>
        /// Calculation Histories Controller
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetHistory")]
        public async Task<IActionResult> GetHistory()
        {
            var response = await _calculatorService.GetHistory();
            return Ok(response);
        }
    }
}
