Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);

if ( number > 99 && number < 1000 )
{
    Console.WriteLine(str[1]);
}
else
{
    Console.WriteLine("не трехзначное число");
}