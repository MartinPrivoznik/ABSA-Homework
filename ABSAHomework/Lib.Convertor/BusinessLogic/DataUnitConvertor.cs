using Lib.Convertor.Core;

namespace Lib.Convertor.BusinessLogic
{
    public class DataUnitConvertor : ConvertorBase
    {
        public DataUnitConvertor()
        {
            _supportedUnits = new Dictionary<string, double>()
            {
                { "bit", 1 },
                { "byte", 8 }
            };
        }
    }
}
