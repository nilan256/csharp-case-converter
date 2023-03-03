# csharp-case-converter
Convert text between any case.


[case-converter](https://github.com/jawira/case-converter) implemented in c#.


## Installation

clone into your project.


## Usage

```csharp
string text = "ThisIsMyName"; // or any support case bellow.

Console.WriteLine("camel: " + CaseConverter.ToCamel(text)); // thisIsMyName
Console.WriteLine("pascal: " + CaseConverter.ToPascal(text)); // ThisIsMyName
Console.WriteLine("snake: " + CaseConverter.ToSnake(text)); // this_is_my_name
Console.WriteLine("ada: " + CaseConverter.ToAda(text)); // This_Is_My_Name
Console.WriteLine("marco: " + CaseConverter.ToMarco(text));// THIS_IS_MY_NAME
Console.WriteLine("kebab: " + CaseConverter.ToKebab(text)); // this-is-my-name
Console.WriteLine("train: " + CaseConverter.ToTrain(text)); // This_Is_My_Name
Console.WriteLine("cobol: " + CaseConverter.ToCobol(text)); // THIS-IS-MY-NAME
Console.WriteLine("lower: " + CaseConverter.ToLower(text)); // this is my name
Console.WriteLine("upper: " + CaseConverter.ToUpper(text)); // THIS IS MY NAME
Console.WriteLine("title: " + CaseConverter.ToTitle(text)); // This Is My Name
Console.WriteLine("sentence: " + CaseConverter.ToSentence(text)); // This is my name
Console.WriteLine("dot: " + CaseConverter.ToDot(text)); // this.is.my.name
```

### Hungarian Notation

use "CaseConverter.EnableHungarianNotationParsing" to toggle this option.

```csharp
CaseConverter.EnableHungarianNotationParsing = true; // default is true
CaseConverter.ToSnake("mMyName"); // my_name
CaseConverter.EnableHungarianNotationParsing = false;
CaseConverter.ToSnake("mMyName"); // m_my_name
```

### Custom delimiter

Default delimiters:
* '-' (dash)
* '_' (underscore)
* ' ' (white space)
* '.' (dot)

Add custom delimiter by this.

```csharp
CaseConverter.Delimiters.Add('+');
```


## License
The MIT LICENSE.

