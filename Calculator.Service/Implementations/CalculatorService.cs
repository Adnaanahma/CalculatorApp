using Calculator.Model.Entity;
using CalculatorMigration.MigrationSpace;
using CalculatorModel.ViewModel;

namespace Calculator.Service.Implementations
{
    public class CalculatorService : ICalculatorService
    {
        private readonly CalculatorContext _calculatorContext;

        public CalculatorService(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }
        /// <summary>
        /// Addition Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Addition(AdditionModel model)
        {
            var formula = model.NumberA + model.NumberB;

            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Addition",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Subtraction Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Subtraction(SubtractionModel model)
        {
            var formula = model.NumberA - model.NumberB;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Subtraction",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Acceleration Of An Object
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Acceleration(AccelerationModel model)
        {
            var formula = model.Velocity / model.Time;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Acceleration",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Division Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Division(DivisionModel model)
        {
            var formula = model.NumberA / model.NumberB;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Division",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Multiplication Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Multiplication(MultiplicationModel model)
        {
            var formula = model.NumberA * model.NumberB;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Multiplication",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Area Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Area(AreaOfRectangleModel model)
        {
            var formula = model.NumberA * model.NumberB;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Area",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Volume Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Volume(VolumeOfCubeModel model)
        {
            var formula = model.NumberA * model.NumberB * model.NumberC;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Volume",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Weight Of Two Numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Weight(WeightOfObjectModel model)
        {
            var formula = model.Mass * model.AccelerationDG;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Weight",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// SquareRoot Of A Number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> SquareRoot(SquareRootModel model)
        {
            var formula = Math.Sqrt(model.NumberA);
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "SquareRoot",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Exponential Of Two Number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Exponential(RaiseToPowerModel model)
        {
            var formula = Math.Pow(model.NumberA, model.NumberB);
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Exponential",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Density Of An Object
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Density(DensityOfObjectModel model)
        {
            var formula = model.Mass / model.Volume;
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Density",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Percentage Of A Number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<double> Percentage(PercentageModel model)
        {
            var formula = (model.NumberA / 100);
            var history = new CalculationHistory
            {
                DataPerformed = DateTime.Now,
                Action = "Percentage",
                Answer = formula.ToString()
            };
            _calculatorContext.Calculator.Add(history);
            await _calculatorContext.SaveChangesAsync();
            return formula;
        }
        /// <summary>
        /// Calculation Histories
        /// </summary>
        /// <returns></returns>MO
        public async Task<List<CalculationHistoryModel>> GetHistory()
        {
            try
            {
                var user = _calculatorContext.Calculator.ToList();
                var CalculationList = new List<CalculationHistoryModel>();

                foreach (var item in user)
                {
                    CalculationHistoryModel history = new CalculationHistoryModel()
                    {
                        Action = item.Action,
                        DataPerformed = item.DataPerformed,
                        Answer = item.Answer,
                    };
                    CalculationList.Add(history);
                };
                return CalculationList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

       



    }   

}           

