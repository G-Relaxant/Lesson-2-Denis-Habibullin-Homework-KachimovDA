int number = Input("Input number: ");

SearchAndWrite(number);


// Методы

int DivToThree(int a)       // Уменьшение до 3х значного числа (функция)
{
    int b = 0;
    while(a > 999)
    {
        b = a / 10;
        a = b;
    }
    return b;
}

int Input(string output)        // Считывание введённого числа (функция)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int ThirdNumFunc(int a)         // Нахождение 3й цифры (функция)
{
    int num = a % 10;
    return num;
}

void SearchAndWrite(int number)         // Основной алгоритм (процедура)
{
    if(number < 1000 && number > 99)
    {
        int digit3 = ThirdNumFunc(number);
        Console.WriteLine("Third  digit = " + digit3);
    }
    else
    {
        if(number > 999)
        {
            int number3 = DivToThree(number);
            int digit3 = ThirdNumFunc(number3);
            Console.WriteLine("Third  digit = " + digit3);
        }
        else
        {
            if(number < 100 && number > -100)
            {
                Console.WriteLine("Third digit in your number is missing");
            }
            else
            {
                if(number > -1000 && number < -99)
                {
                    number = number * -1;
                    int digit3 = ThirdNumFunc(number);
                    Console.WriteLine("Third  digit = " + digit3);
                }
                else
                {
                    if(number < -999)
                    {
                        number = number * -1;
                        int number3 = DivToThree(number);
                        int digit3 = ThirdNumFunc(number3);
                        Console.WriteLine("Third  digit = " + digit3);
                    }
                }
            }
        }
    }
}