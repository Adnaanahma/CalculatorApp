using Calculator.Model.Entity;
using CalculatorModel.ViewModel;

namespace Calculator.Service.Implementations
{
    public interface ICalculatorService
    {
        Task<double> Addition(AdditionModel model);
        Task<double> Subtraction(SubtractionModel model);
        Task<double> Division(DivisionModel model);
        Task<double> Multiplication(MultiplicationModel model);
        Task<double> Area(AreaOfRectangleModel model);
        Task<double> Volume(VolumeOfCubeModel model);
        Task<double> Weight(WeightOfObjectModel model);
        Task<double> SquareRoot(SquareRootModel model);
        Task<double> Exponential(RaiseToPowerModel model);
        Task<double> Density(DensityOfObjectModel model);
        Task<double> Percentage(PercentageModel model);
        Task<double> Acceleration(AccelerationModel model);
        Task<List<CalculationHistoryModel>> GetHistory();
        
    }
}
