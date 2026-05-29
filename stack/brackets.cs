using System;
using System.Collections.Generic;
class HelloWorld {
	static void Main() {
	    string s = "({)";
		Console.WriteLine(bracketOrder(s));
	}
	public static bool bracketOrder(string s) {
		var stack = new Stack<char>();
		for (int i = 0; i < s.Length; i++) {
			char c = s[i];
			if (c == '(' || c == '{' || c== '[') {
				stack.Push(c);
			}
			else {
				if (stack.Count == 0) {
					return false;
				}
				if (c == ')' && stack.Pop() != '(') {
					return false;
				}
				if (c == '}' && stack.Pop() != '{') {
					return false;
				}
				if (c == ']' && stack.Pop() != '[') {
					return false;
				}

			}
		}
		return stack.Count == 0;
	}
}