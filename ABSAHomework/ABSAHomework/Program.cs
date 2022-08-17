using Lib.Convertor;

UnitConvertor unitConvertor = new UnitConvertor();

//Making it async feels useful in preview console app :-)
var resData = unitConvertor.ConvertDataAsync("300 microbyte", "bit").GetAwaiter().GetResult();
var resData2 = unitConvertor.ConvertDataAsync("123456 kilobit", "megabyte").GetAwaiter().GetResult();
var resLength = unitConvertor.ConvertLengthAsync("1 meter", "feet").GetAwaiter().GetResult();
var resLength2 = unitConvertor.ConvertLengthAsync("3 kiloinch", "meter").GetAwaiter().GetResult();
var resTemperature = unitConvertor.ConvertTemperatureAsync("-40 fahrenheit", "celsius").GetAwaiter().GetResult();
var resTemperature2 = unitConvertor.ConvertTemperatureAsync("70 fahrenheit", "celsius").GetAwaiter().GetResult();
var resTemperature3 = unitConvertor.ConvertTemperatureAsync("20 celsius", "fahrenheit").GetAwaiter().GetResult();

var x = 1;