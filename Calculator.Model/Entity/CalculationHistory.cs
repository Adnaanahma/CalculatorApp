namespace Calculator.Model.Entity
{
    public class CalculationHistory
    {
        public int Id { get; set; }
        public DateTime DataPerformed { get; set; }
        public string Action { get; set; }
        public string Answer { get; set; }
    }
}
