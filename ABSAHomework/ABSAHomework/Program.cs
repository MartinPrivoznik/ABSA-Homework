using Lib.Convertor;

UnitConvertor unitConvertor = new UnitConvertor();

var res = unitConvertor.ConvertDataAsync("30000 megabyte", "terabit").GetAwaiter().GetResult();

var x = 1;