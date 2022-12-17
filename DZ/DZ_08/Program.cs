Console.WriteLine("Эта программа будет искать все четный числа от 1 до N");
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
while (n<=number) 
{
    if (n % 2 == 0) Console.WriteLine($"четные числа от 1 до {number}: {n};"); 
    n = n + 1; 
}