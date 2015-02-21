using System;
class Program {
	static void Main() {
		var s = "var s = {1}{0}{1};Console.WriteLine(s,s,(char)34);";
		Console.WriteLine(s, s, (char)34);
		for (int i = 1; i < 50; ++i) {
			if (i % 15 == 0) Console.WriteLine(new string(new char[] { (char)0x46, (char)0x69, (char)0x7a, (char)0x7a, (char)0x42, (char)0x75, (char)0x7a, (char)0x7a }));
			if (i % 5 == 0) Console.WriteLine(new string(new char[] { (char)0x42, (char)0x75, (char)0x7a, (char)0x7a }));
			if (i % 3 == 0) Console.WriteLine(new string(new char[] { (char)0x46, (char)0x69, (char)0x7a, (char)0x7a }));
			else Console.WriteLine(i);
		}
	}
}
