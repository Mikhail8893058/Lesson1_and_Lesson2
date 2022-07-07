Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);

if ( number > 99)
{
    Console.Write("третья цифру заданного числа = ");
    Console.Write(str[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

