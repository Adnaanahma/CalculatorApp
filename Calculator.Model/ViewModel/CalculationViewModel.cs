namespace CalculatorModel.ViewModel
{
    public class AdditionModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
    }
    public class SubtractionModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
    }
    public class MultiplicationModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
    }
    public class DivisionModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
    }
    public class AccelerationModel
    {
        public double Velocity { get; set; }
        public double Time { get; set; }
    }
    public class AreaOfRectangleModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
    }
    public class VolumeOfCubeModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public double NumberC { get; set;}
    }
    public class WeightOfObjectModel
    {
        public double Mass { get; set; }
        public double AccelerationDG { get; set; }
    }
    public class SquareRootModel
    {
        public double NumberA { get; set; }
        
    }
    public class RaiseToPowerModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
    }
    public class DensityOfObjectModel
    {
        public double Mass { get; set; }
        public double Volume { get; set; }
    }
    public class PercentageModel
    {
        public double NumberA { get; set; }
    }

    public class CalculationHistoryModel
    {
        public DateTime DataPerformed { get; set; }
        public string Action { get; set; }
        public string Answer { get; set; }
    }

}
