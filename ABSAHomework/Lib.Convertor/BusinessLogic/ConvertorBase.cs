using Lib.Convertor.Helpers;

namespace Lib.Convertor.BusinessLogic
{
    public abstract class ConvertorBase
    {
        private SIPrefixHelper _sIPrefixHelper = new();

        /// <summary>
        /// the unit by which others will be measured
        /// </summary>
        private string _baseUnit;

        /// <summary>
        /// Name and Diff values of supported units.
        /// For example if base unit is bit then supported unit can be < "byte", 8 >
        /// set base unit to 1
        /// </summary>
        protected IDictionary<string, double> _supportedUnits;

        public ConvertorBase(string baseUnit)
        {
            _baseUnit = baseUnit;
        }

    }
}
