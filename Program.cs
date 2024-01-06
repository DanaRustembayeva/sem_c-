/* Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/

// тип_данных_имя_переменной = значение;
// camelCase: firstNumber, secondNumber
// int number =  9; // number = 9
// int result = number * number; //81

// Console.ReadLine() - получить информацию из строчки
Console.Write("Введите первое число: "); //a
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); //b
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) // true
{
    Console.WriteLine("Да" + firstNumber + "является кв. от числа" + secondNumber);
}
else // а не яляется кв от числа b
{
    Console.WriteLine("НЕТ" + firstNumber + "НЕ является кв. от числа" + secondNumber);
}

// on Windows: shift+Alt+F

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите число N: "); 
int N = Convert.ToInt32(Console.ReadLine ()); //N=4
if (N<0) //-5*(-1)=5
{
    Console.WriteLine("ВВедено отр.число N");
    N = N * -1;
}
int negativeN = N * -1; //-4

while (negativeN <= N)// -3-2-10123
{
    Console.Write(negativeN + " ");
    negativeN++; // negativeN++ (negativeN = negativeN + 1)
}
