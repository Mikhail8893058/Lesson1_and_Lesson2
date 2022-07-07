Console.WriteLine("Введите number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max;
int min;


if (number1 > number2)
{
   max = number1;
   min = number2;   
}
else
{
   max = number2;
   min = number1;  
}
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);