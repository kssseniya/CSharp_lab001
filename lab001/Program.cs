//Минимальные и максимальные значения для целочисленных типов данных:
Console.WriteLine("Целочисленные типы данных:");
Console.WriteLine($"sbyte: Минимальное = {sbyte.MinValue}, Максимальное = {sbyte.MaxValue}");
Console.WriteLine($"byte: Минимальное = {byte.MinValue}, Максимальное = {byte.MaxValue}");
Console.WriteLine($"short: Минимальное = {short.MinValue}, Максимальное = {short.MaxValue}");
Console.WriteLine($"ushort: Минимальное = {ushort.MinValue}, Максимальное = {ushort.MaxValue}");
Console.WriteLine($"int: Минимальное = {int.MinValue}, Максимальное = {int.MaxValue}");
Console.WriteLine($"uint: Минимальное = {uint.MinValue}, Максимальное = {uint.MaxValue}");
Console.WriteLine($"long: Минимальное = {long.MinValue}, Максимальное = {long.MaxValue}");
Console.WriteLine($"ulong: Минимальное = {ulong.MinValue}, Максимальное = {ulong.MaxValue}");

// Минимальное и максимальное значения для типов с плавающей точкой:
Console.WriteLine("\nТипы с плавающей точкой:");
Console.WriteLine($"float: Минимальное = {float.MinValue}, Максимальное = {float.MaxValue}");
Console.WriteLine($"double: Минимальное = {double.MinValue}, Максимальное = {double.MaxValue}");
Console.WriteLine($"decimal: Минимальное = {decimal.MinValue}, Максимальное = {decimal.MaxValue}");

// Минимальное и максимальное значения для символьного типа данных:
Console.WriteLine("\nСимвольный тип данных:");
Console.WriteLine($"char: Минимальное = {char.MinValue}, Максимальное = {char.MaxValue}");

// Минимальное и максимальное значения для булевого типа данных:
Console.WriteLine("\nБулевый тип данных:");
Console.WriteLine($"bool: Минимальное = {bool.FalseString}, Максимальное = {bool.TrueString}");
Console.WriteLine( sizeof (double));