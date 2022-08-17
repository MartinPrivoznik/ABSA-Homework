using Lib.Convertor.Core;
using Lib.Convertor.Models;

namespace Lib.Convertor.BusinessLogic
{
    public abstract class FormulaBasedConvertorBase : IConvertor
    {
        /// <summary>
        /// List of possible conversions and conversion formulas
        /// </summary>
        protected IList<FormulaUnitsConversion> _supportedConversions = new List<FormulaUnitsConversion>();

        public Task<string> Convert(string from, string to)
        {
            return Task.Run(() =>
            {
                //Prepare from value
                var fromSplitted = from.Split(' ');

                var fromValue = double.Parse(fromSplitted[0]);
                var fromName = fromSplitted[1];

                //Check for valid formula
                var conversion = _supportedConversions.Where(con => con.From == fromName && con.To == to).First();

                var x = conversion.Formula(fromValue);

                //Run the delegate and return
                return $"{conversion.Formula(fromValue)} {to}";
            });
        }
    }
}
