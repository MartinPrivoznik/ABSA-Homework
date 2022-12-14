using Lib.Convertor.BusinessLogic;
using Lib.Convertor.Core;

namespace Lib.Convertor
{
    public class UnitConvertor : IUnitConvertor
    {
        private DataUnitConvertor _dataUnitConvertor = new();
        private LengthUnitConvertor _lengthUnitConvertor = new();
        private TemperatureUnitConvertor _temperatureUnitConvertor = new();

        public async Task<string> ConvertDataAsync(string from, string to)
        {
            return await _dataUnitConvertor.Convert(from, to);
        }

        public async Task<string> ConvertLengthAsync(string from, string to)
        {
            return await _lengthUnitConvertor.Convert(from, to);
        }

        public async Task<string> ConvertTemperatureAsync(string from, string to)
        {
            return await _temperatureUnitConvertor.Convert(from, to);
        }
    }
}