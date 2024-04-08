using System;

class Calculator
{
	static void Main()
	{
		Console.WriteLine("Вас приветсвует приложение Калькулятор!");
		string choice = "n";
		while (choice.ToLower() == "n")
		{
			Console.WriteLine("Введите первое число:");
			double num1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите операцию (+, -, *, /):");
			char operation = Convert.ToChar(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			double num2 = Convert.ToDouble(Console.ReadLine());

			double result = 0;

			if (operation == '+')
			{
				result = num1 + num2;

				Console.WriteLine("Результат: " + result);
			}
			else if (operation == '-')
			{
				result = num1 - num2;

				Console.WriteLine("Результат: " + result);
			}
			else if (operation == '*')
			{
				result = num1 * num2;

				Console.WriteLine("Результат: " + result);
			}
			else if (operation == '/')
			{
				if (num2 == 0)
				{
					Console.WriteLine("Ошибка! Делить на ноль нельзя!");
				}
				else
				{
					result = num1 / num2;

					Console.WriteLine("Результат: " + result);
				}
			}
			Console.WriteLine("Завершить работу программы (Y / N)?");
			choice = Console.ReadLine();
		}
	}
}
