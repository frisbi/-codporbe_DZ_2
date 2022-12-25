// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите трехзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA > -100 && numA < 100)
{
    Console.WriteLine($"Третьей цифры во введенном числе {numA} нет");  
}
else
{
  while (numA <= -1000 || numA >= 1000)
  {
    numA /= 10;
  }  
  int numB = numA % 10;
  Console.WriteLine($"Третья цифра -> {numB}");
}
