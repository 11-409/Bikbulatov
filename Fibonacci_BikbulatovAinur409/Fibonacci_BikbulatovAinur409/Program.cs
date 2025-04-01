using Fibonacci_BikbulatovAinur409;

Console.Write("Число Фибоначчи под каким номером вы хотите узнать: ");
int.TryParse(Console.ReadLine(), out int n);

Console.WriteLine($"Число Фибоначчи под номером {n} - {Fibonacci.CountFibonacci(n)}");
