int daynum = Input("Input week's day number: ");

Procedure(daynum);



void Procedure(int daynum)      // Основной алгоритм (процедура)
{
    if(daynum < 8 && daynum > 0)
    {
        if(daynum > 5)
        {
            Console.WriteLine("Yes, this day is weekend");
        }
        else
        {
            Console.WriteLine("No, this day is weekday");
        }
    }
    else
    {
        Console.WriteLine("You input incorrect number");
    }
}


int Input(string output)        // Считывание введённого числа (функция)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}