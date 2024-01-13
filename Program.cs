// Напишите программу, которая на вход
// принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.Readline() - получить информацию из строчки
Console.Write("Ввести число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввести число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// f = 25; s = 5: f == s*s, 25 == 5 * 5
if(firstNumber == secondNumber * secondNumber) //  а является кв от числа b
{
    Console.WriteLine("Да, " + firstNumber + "да является кв. от числа " + secondNumber);
}
else // а не является кв от числа b
{
    Console.WriteLine("Нет, " + firstNumber + "не является кв. от числа " + secondNumber);
}