namespace Lib.Convertor.BusinessLogic
{
    public class LengthUnitConvertor : ConvertorBase
    {
        public LengthUnitConvertor()
        {
            _supportedUnits = new Dictionary<string, double>()
            {
                { "meter", 1 },
                { "feet", 0.3048 }, //1 feet = 0.3048 meters
                { "inch", 0.0254 } //1 inch = 0.0254 meters
            };
        }
    }
}
