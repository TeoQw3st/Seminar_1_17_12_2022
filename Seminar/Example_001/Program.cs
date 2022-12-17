Console.WriteLine("Введите число:");// c помощью этого оператора мы вывродим на экран текст
int number = Convert.ToInt32(Console.ReadLine());// c помощью этого оператора мы заставляем оператора ввести число
int sqr = number * number; //ввели переменную
// Console.Write("Квадрат числа "+ number + " равен: " +sqr);
Console.Write($"Квадрат числа  {number} равен:  {sqr}"); // интерполяция

