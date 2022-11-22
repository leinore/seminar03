// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Диапазон координат x > 0, y > 0");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Диапазон координат x < 0, y > 0");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Диапазон координат x < 0, y < 0");
// }
// else
// {
//     Console.WriteLine("Диапазон координат x > 0, y < 0");
// }

string [] quarters = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter >= 1 && quarter <=4)
{
    Console.WriteLine(quarters[quarter-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}