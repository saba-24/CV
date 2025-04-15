namespace mvc_test.Models
{
    public class IncomeModel
    {
        public float YearlyWage { get; set; }
        public float IncomeTax {  get; set; } 
        public IncomeModel(float i)
        {
            YearlyWage = i;
            IncomeTax = i > 30000 ? i / 5 : 0;          
        }
    }
}
