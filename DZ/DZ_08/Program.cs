Console.WriteLine("Эта программа будет искать все четный числа от 1 до N");
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
int sum = 0;
while (n<number) 
{
    if (n % 2 == 0)
    sum = sum +n;
    else
    n = n + 1;
n = n +1;    
}
Console.Write(sum);