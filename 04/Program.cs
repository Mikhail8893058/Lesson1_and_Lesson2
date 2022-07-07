Console.WriteLine("Введите любое число: ");
int numN = Convert.ToInt32(Console.ReadLine());

int min = 2;

while (min < numN)
{
    Console.Write(min + ", ");
    min = min + 2;
}
Console.WriteLine(min);


