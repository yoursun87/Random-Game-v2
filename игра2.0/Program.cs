// See https://aka.ms/new-console-template for more information
Random rand = new Random();
int a = rand.Next(50);
int count = 1;
Console.WriteLine("Компьютер загадал число от 0 до 50 . отгадайте его,используя 3 попытки");
Console.WriteLine("Введите первое число:");
int b = Convert.ToInt32((Console.ReadLine()));

while (count <= 3)
{
    if (a == b)
    {
        Console.WriteLine("Поздравляем вы угадали число с X попытки");
        break;
    }
    else
    {

        count++;
        if (count == 4)
        {
            Console.WriteLine(" Вы не угадали число . Загаданным числом было "+ a +"!");

            break;


        }
        Console.WriteLine("Это не число" + b + ". Попытка №" + count + ":");

        b = Convert.ToInt32(Console.ReadLine());
    }
}
Console.ReadLine();

   




    