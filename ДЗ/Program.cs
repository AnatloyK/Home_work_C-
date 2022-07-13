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

// Задачи "Заvoidены")))