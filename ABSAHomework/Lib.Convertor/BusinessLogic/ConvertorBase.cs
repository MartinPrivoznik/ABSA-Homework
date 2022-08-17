using Lib.Convertor.Helpers;

namespace Lib.Convertor.BusinessLogic
{
    public abstract class ConvertorBase
    {
        private SIPrefixHelper _sIPrefixHelper = new();

        /// <summary>
        /// Name and Diff values of supported units.
        /// For example if base unit is bit then supported unit can be < "byte", 8 >
        /// set base unit to 1
        /// </summary>
        protected IDictionary<string, double> _supportedUnits = new Dictionary<string, double>();

        public Task<string> Convert(string from, string to)
        {
            return Task.Run(() =>
            {
                //Prepare from value
                var fromSplitted = from.Split(' ');

                var fromValue = double.Parse(fromSplitted[0]);
                var fromName = fromSplitted[1];

                //Convert it to base value (no prefix)
                ConvertToBaseSIValue(ref fromName, ref fromValue);

                //Convert to base unit
                var fromBaseUnitValue = GetBaseUnitValue(fromName, fromValue);

                //Convert to new one
                var toResultExponent = _sIPrefixHelper.GetUnitPrefixExponent(to);
                var toResultValue = GetValueWithSI(GetNewUnitValue(_sIPrefixHelper.GetUnitNameWithoutPrefix(to), fromBaseUnitValue), toResultExponent);

                return $"{toResultValue} {to}";
            });
        }

        private double GetNewUnitValue(string newUnitName, double baseUnitValue)
        {
            //Not the most accurate way of calculation
            var coeficient = _supportedUnits.Where(unit => unit.Key == newUnitName).First().Value;
            return baseUnitValue / coeficient;
        }

        private double GetBaseUnitValue(string name, double value)
        {
            var coeficient = _supportedUnits.Where(unit => unit.Key == name).First().Value;
            return value * coeficient;
        }

        /// <summary>
        /// 1 kilometer => 1000 meters where meter is base unit
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void ConvertToBaseSIValue(ref string name, ref double value)
        {
            var oldName = name;
            name = _sIPrefixHelper.GetUnitNameWithoutPrefix(oldName);
            value = value * Math.Pow(10, _sIPrefixHelper.GetUnitPrefixExponent(oldName));
        }

        private double GetValueWithSI(double value, int exponent)
        {
            return value / Math.Pow(10, exponent);
        }
    }
}
