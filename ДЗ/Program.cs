void Zadacha1()  //Задача на нахождение max 2 чисел
{
    Console.WriteLine("Введите первое число");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if(numberA > numberB)
    {
        Console.WriteLine($"большее число - {numberA}");
        Console.WriteLine($"меньшее число - {numberB}");
    }
    else
    {
        Console.WriteLine($"большее число -  {numberB}");
        Console.WriteLine($"меньшее число -  {numberA}");
    }
}

void Zadacha2()  // Задача на нахождение max 3 чисел
{
    Console.WriteLine("Введите первое число");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int numberC = Convert.ToInt32(Console.ReadLine());
    int max = numberA;
    if(max<numberB) max = numberB;
    if(max<numberC) max = numberC;
    Console.WriteLine($"Самое большое число - {max}");
}    

void Zadacha3() // Задача на целоделимость числа
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number % 2 == 0)
    {
        Console.WriteLine("Число делится на 2");
    }
    else
    {
        Console.WriteLine("Число не делится на 2");
    }
}

void Zadacha4()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int startnumber = 0;
    while (startnumber != (number+1))
    {
        if (startnumber % 2 == 0)
        {
            Console.WriteLine(startnumber + " ");
        }
        else
        {

        }
        startnumber++;
    }
}

void Zadacha5() //Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    Console.WriteLine("Введите любое 3-х значное число");
    Console.Write("a = ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    if (numberA < 100)
    {
        Console.WriteLine("У заданного числа нет 3 цифры");
    }
    else
    {
        int result = (numberA % 100) % 10;
        Console.WriteLine(result);
    }
}

void Zadacha6() //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
    Console.WriteLine("Введите цифру дня недели");
    Console.Write("День недели = ");
    int NumDay = Convert.ToInt32(Console.ReadLine());
    if (NumDay > 0 && NumDay < 8)
        if (NumDay == 6 || NumDay == 7)
        {
            if (NumDay == 6) Console.WriteLine("Суббота выходной день");
            if (NumDay == 7) Console.WriteLine("Воскресенье выйходной день");
        }
        else
        {
            Console.WriteLine("На работу =(");
        }
    else
    {
        Console.WriteLine("Неверное значение");
    }
}
Zadacha6();


// Задачи "Заvoidены")))