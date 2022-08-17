using Lib.Convertor.Models;

namespace Lib.Convertor.BusinessLogic
{
    public class TemperatureUnitConvertor : FormulaBasedConvertorBase
    {
        public TemperatureUnitConvertor()
        {
            _supportedConversions = new List<FormulaUnitsConversion>
            {
                new FormulaUnitsConversion
                {
                    From = "celsius",
                    To = "fahrenheit",
                    Formula = (double celsius) => { return (celsius * 1.8) + 32.0; }
                },
                new FormulaUnitsConversion
                {
                    From = "fahrenheit",
                    To = "celsius",
                    Formula = (double fahrenheit) => { return (fahrenheit - 32.0) * (5.0 / 9.0); }
                },
            };
        }
    }
}
