namespace Lib.Convertor.Core
{
    public interface IConvertor
    {
        Task<string> Convert(string from, string to);
    }
}
