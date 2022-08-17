# ABSA-Homework

In project, you can find Console app and a class Library. Class library implements funcionality and there are some sample function calls prepared in a Console app.

## Pseudo-Documentation

### UnitConvertor
UnitConvertor implements 3 unit conversion functions.
- Data unit conversion - ```ConvertDataAsync(string from, string to)```
- Length unit conversion - ```ConvertLengthAsync(string from, string to)```
- Temperature unit conversion - ```ConvertTemperatureAsync(string from, string to)```

To correctly call a function, always use singular, eg. ```ConvertLengthAsync("12 kiloinch", "feet")```

Functions return string with converted value - ```1000 feet``` can be a return value of a funcion call mentioned above

### Business logic
There are 2 kinds of conversions. 
Base conversions including SI table eg. ```300 microbyte to bit``` and formula based conversions eg. ```30 celsius to fahrenheit```

For each kind of conversion there is a base class including a conversion function - ```Convert(string from, string to)```. 
Every base class should implement ```IConvertor``` to make sure it implements conversion function

What SIPrefixHelper class does is exporting basic functions of SI prefix workaround, like calculating desired exponent of a prefix according to Wikipedia.org

## Implementing a new functionality
To implement a new convertor all you need is to create a new conversion class and define supported values

Base convertor classes implement ```IDictionary<string, double> _supportedUnits``` which can be filled in constructor

Formula-based convertor classes implement ```IList<FormulaUnitsConversion> _supportedConversions```

### _supportedUnits
Insert name and difference from base unit. Base unit can be any of your choice and must have value ```1``` in a dictionary.
Other units values are differences eg. if bit is your base unit and would like to implement byte conversion, 
your dictionary should look like the following: ```{ "bit", 1 }, { "byte", 8 }``` (1 byte = 8 bits)

Example usage can be found in ```DataUnitConvertor.cs``` or ```LengthUnitConvertor.cs```

### _supportedConversions
Insert from unit name, to unit name and conversion formula, which is described by a class called ```FormulaUnitsConversion```.
Formula is a delegate and can be defined while initializing the List. 

Example usage can be found in ```TemperatureUnitConvertor.cs```
