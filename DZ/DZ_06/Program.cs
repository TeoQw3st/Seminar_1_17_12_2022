// See https://aka.ms/new-console-template for more information
Console.WriteLine("Это программа в идеале будет проверять является число четным или нет");
Console.WriteLine("Введие число ");
int number = Convert.ToInt32(Console.ReadLine());

 if (number % 2 == 0)
    {
        Console.WriteLine($"Число {number} четное");
        }
        else
        {
            Console.WriteLine($"Число {number} не четное");
            }

