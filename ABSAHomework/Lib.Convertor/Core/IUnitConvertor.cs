namespace Lib.Convertor.Core
{
    public interface IUnitConvertor
    {
        //In case user wanted to use dependency injection
        Task<string> ConvertLengthAsync(string from, string to);
        Task<string> ConvertDataAsync(string from, string to);
        Task<string> ConvertTemperatureAsync(string from, string to);
    }
}
