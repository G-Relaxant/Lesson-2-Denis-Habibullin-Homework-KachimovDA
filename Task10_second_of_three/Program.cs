int number = Input("Input number: ");

if(number > 99 && number < 1000)
{
    int secnum = SecNumFunc(number);
    Console.WriteLine("Second digit = " + secnum);
}
else
{
    Console.WriteLine("You input incorrect number");
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int SecNumFunc(int a)
{
    int num = a / 10;
    int sec = num % 10;
    return sec;
}