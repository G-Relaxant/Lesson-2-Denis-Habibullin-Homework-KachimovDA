// 1 Вариант
/*int number1 = Input("Введите первое число: ");      // Применение метода ввода-вывода(12 строка)
int number2 = Input("Введите второе число ");

if(number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Числа тождественны как квадрат и его корень (или наоборот)");
}
else
{
    Console.WriteLine("Числа нетождественны как корень и квадрат (или наоборот)");
}
int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}*/



// 2 Вариант
int number1 = Input("Введите первое число: ");      // Применение метода ввода-вывода(39 строка)
int number2 = Input("Введите второе число ");

if(Square(number1) == number2 || Square(number2) == number1)    // Применение метода возведения в квадрат(34 строка)
{
    Console.WriteLine("Да, числа взаимны как квадрат и его корень (или наоборот)");
}
else
{
    Console.WriteLine("Нет, числа не взаимны как корень и квадрат (или наоборот)");
}

int Square(int a)                                  // Инициализация метода возведения в квадрат
{
    return a * a;
}

int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}