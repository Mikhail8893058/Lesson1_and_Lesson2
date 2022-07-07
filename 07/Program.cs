Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
int Days = Convert.ToInt32(Console.ReadLine());

int saturday = 6;
int sunday = 7;

if (Days == saturday || Days ==sunday)
{
    Console.WriteLine("Выходной день");
}
else if (Days > 7 || Days <= 0)
{
    Console.WriteLine("Цифры от 1 до 7!");
}
else
{
    Console.WriteLine("Не выходной день.");
} 
