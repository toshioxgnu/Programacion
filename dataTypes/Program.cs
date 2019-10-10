using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte");	
        	Console.WriteLine("Minimo: " + byte.MinValue );
        	Console.WriteLine("Maximo: " + byte.MaxValue);
        	Console.WriteLine("sByte");	
        	Console.WriteLine("Minimo: " + sbyte.MinValue);
        	Console.WriteLine("Maximo: " + sbyte.MaxValue);
        	Console.WriteLine("Short");	
        	Console.WriteLine("Minimo: " + short.MinValue);
        	Console.WriteLine("Maximo: " + short.MaxValue);
        	Console.WriteLine("Ushort");	
        	Console.WriteLine("Minimo: " + ushort.MaxValue);
        	Console.WriteLine("Maximo: " + ushort.MaxValue);
        	Console.WriteLine("Uint");
        	Console.WriteLine("Minimo: " + uint.MaxValue);
        	Console.WriteLine("Maximo: " + uint.MaxValue);
        	Console.WriteLine("Ulong");	
        	Console.WriteLine("Maximo: " + ulong.MaxValue);
        	Console.WriteLine("Maximo: " + ulong.MaxValue);
			Console.WriteLine("Float");	
        	Console.WriteLine("Minimo: " + float.MinValue );
        	Console.WriteLine("Maximo: " + float.MaxValue);
        	Console.WriteLine("Double");	
        	Console.WriteLine("Minimo: " + double.MinValue);
        	Console.WriteLine("Maximo: " + double.MaxValue);
        	Console.WriteLine("Decimal");	
        	Console.WriteLine("Minimo: " + decimal.MinValue);
        	Console.WriteLine("Maximo: " + decimal.MaxValue);


			System.Console.WriteLine("Sizeof");
			Console.WriteLine("bytes reservados Byte: " + sizeof(byte) );
			Console.WriteLine("bytes reservados sByte: " + sizeof(sbyte) );
			Console.WriteLine("bytes reservados short: " + sizeof(short) );
			Console.WriteLine("bytes reservados ushort: " + sizeof(ushort) );
			Console.WriteLine("bytes reservados Uint: " + sizeof(uint) );
			Console.WriteLine("bytes reservados ulong: " + sizeof(ulong) );
			Console.WriteLine("bytes reservados float: " + sizeof(float) );
			Console.WriteLine("bytes reservados Double: " + sizeof(double) );
			Console.WriteLine("bytes reservados Decimal: " + sizeof(decimal) );
			Console.WriteLine("bytes reservados char: " + sizeof(char) );
			Console.WriteLine("bytes reservados Bool: " + sizeof(bool) );

			var h = 1.93;

			Console.WriteLine(h);













        }
    }
}
