// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string str = "Hello my world";
string[] words = str.Split(' ');
Array.Reverse(words);
string result = string.Join(" ", words);

Console.WriteLine(result);