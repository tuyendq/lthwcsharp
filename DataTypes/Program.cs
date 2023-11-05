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
