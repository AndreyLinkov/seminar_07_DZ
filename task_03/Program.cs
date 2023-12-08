// Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "Шалаш".ToLower();
char[] array = str.ToCharArray();
Array.Reverse(array);
string newStr = new string(array);

if (str == newStr)
    Console.WriteLine($"Строка '{str}' является палиндромом");
else
    Console.WriteLine($"Строка '{str}' не является палиндромом");