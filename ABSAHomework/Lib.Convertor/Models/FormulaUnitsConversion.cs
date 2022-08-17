namespace Lib.Convertor.Models
{
    public class FormulaUnitsConversion
    {
        public string From { get; set; }
        public string To { get; set; }
        public Formula Formula { get; set; }
    }

    public delegate double Formula(double fromValue);
}
