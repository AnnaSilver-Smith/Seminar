//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите число: ");
string N = Console.ReadLine();
int S = Convert.ToInt32(N);
Console.WriteLine(S % 2 == 0 ? "Yes" : "No");