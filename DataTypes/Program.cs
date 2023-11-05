System.Console.WriteLine("Numeric data types: There are 11 options to choose.");
System.Console.WriteLine("Signed integral types:");

System.Console.WriteLine($"sbyte    : {sbyte.MinValue} to {sbyte.MaxValue}\t\t\t\t\t\t{sizeof(sbyte)} byte(s)");
System.Console.WriteLine($"short    : {short.MinValue} to {short.MaxValue}\t\t\t\t\t{sizeof(short)} byte(s)");
System.Console.WriteLine($"int      : {int.MinValue} to {int.MaxValue}\t\t\t\t{sizeof(int)} byte(s)");
System.Console.WriteLine($"long     : {long.MinValue} to {long.MaxValue}\t\t{sizeof(long)} byte(s)");

System.Console.WriteLine("Unsigned integral types:");

System.Console.WriteLine($"byte     : {byte.MinValue} to {byte.MaxValue}\t\t\t\t\t\t{sizeof(byte)} byte(s)");
System.Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}\t\t\t\t\t\t{sizeof(ushort)} byte(s)");
System.Console.WriteLine($"uint     : {uint.MinValue} to {uint.MaxValue}\t\t\t\t\t{sizeof(uint)} byte(s)");
System.Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}\t\t\t\t{sizeof(ulong)} byte(s)");

System.Console.WriteLine("Floating point types:");

System.Console.WriteLine($"float      : {float.MinValue} to {float.MaxValue}\t\t\t\t\t{sizeof(float)} byte(s)");
System.Console.WriteLine($"double      : {double.MinValue} to {double.MaxValue}\t\t{sizeof(double)} byte(s)");
System.Console.WriteLine($"decimal      : {decimal.MinValue} to {decimal.MaxValue}\t{sizeof(decimal)} byte(s)");


// Reference data type
System.Console.WriteLine("\nReference data type:");
int[] data;  // null reference
data = new int[3];  // Initialize an array of 3 integers
System.Console.WriteLine(data);

int[] data2 = new int[5];
foreach (var item in data2)
{
    System.Console.Write($"{data2[item]}\t");
}

System.Console.WriteLine("\nString data type:");
string str = "This is a test string.";
System.Console.WriteLine(str);





