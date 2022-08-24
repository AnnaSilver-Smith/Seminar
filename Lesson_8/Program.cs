//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;
bool not = true;            
while (A <= N)
{
	if (A % 2 == 0)
	{
		Console.Write(A + " ");
		not = false;

	}
	A++;
}

Console.WriteLine(" ");

if (not)
{
	Console.WriteLine("Error");
}
