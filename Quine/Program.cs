﻿using System;
using System.Linq;
using System.Collections.Generic;

class Program {
	static void Main() {
		var l = new List<char>(); l.Add((char)0x46); l.Add((char)0x69); l.Add((char)0x7a); l.Add((char)0x7a); l.Add((char)0x42); l.Add((char)0x75); l.Add((char)0x7a); l.Add((char)0x7a); var fb = new string(Enumerable.Range(1, 50).Select(i => (i % 15 == 0) ? l.Aggregate(string.Empty, (s, x) => s + x) : (i % 5 == 0) ? l.Skip(4).Aggregate(string.Empty, (s, x) => s + x) : (i % 3 == 0) ? l.Take(4).Aggregate(string.Empty, (s, x) => s + x) : i.ToString()).Aggregate(string.Empty, (s, x) => s + x + (char)0x7c).ToArray());
		var zz = @"1|2|Fizz|4|Buzz|Fizz|7|8|Fizz|Buzz|11|Fizz|13|14|FizzBuzz|16|17|Fizz|19|Buzz|Fizz|22|23|Fizz|Buzz|26|Fizz|28|29|FizzBuzz|31|32|Fizz|34|Buzz|Fizz|37|38|Fizz|Buzz|41|Fizz|43|44|FizzBuzz|46|47|Fizz|49|Buzz|";
		var str = "var l = new List<char>(); l.Add((char)0x46); l.Add((char)0x69); l.Add((char)0x7a); l.Add((char)0x7a); l.Add((char)0x42); l.Add((char)0x75); l.Add((char)0x7a); l.Add((char)0x7a); var fb = new string(Enumerable.Range(1, 50).Select(i => (i % 15 == 0) ? l.Aggregate(string.Empty, (s, x) => s + x) : (i % 5 == 0) ? l.Skip(4).Aggregate(string.Empty, (s, x) => s + x) : (i % 3 == 0) ? l.Take(4).Aggregate(string.Empty, (s, x) => s + x) : i.ToString()).Aggregate(string.Empty, (s, x) => s + x + (char)0x7c).ToArray());var zz = {1}{2}{1};var str = {1}{0}{1};Console.WriteLine(str,str,(char)34);";
		Console.WriteLine(str, str, (char)34, fb);

	}
}
