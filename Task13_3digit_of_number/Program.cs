int number = Input("Input number: ");

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
        if(number < 100)
        {
            Console.WriteLine("Third digit in your number is missing");
        }
    }
}


int DivToThree(int a)
{
    int b = 0;
    while(a > 999)
    {
        b = a / 10;
        a = b;
    }
    return b;
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int ThirdNumFunc(int a)
{
    int num = a % 10;
    return num;
}