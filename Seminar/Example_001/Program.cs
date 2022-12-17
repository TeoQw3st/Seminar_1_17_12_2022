Console.WriteLine("Введите число:");// c помощью этого оператора мы заставляем пользователя вводить число
int number = Convert.ToInt32(Console.ReadLine());
int sqr = number * number;
// Console.Write("Квадрат числа "+ number + " равен: " +sqr);
Console.Write($"Квадрат числа  {number} равен:  {sqr}"); // интерполяция

