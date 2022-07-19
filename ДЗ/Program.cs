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
    Console.WriteLine("Введите число");
    Console.Write("a = ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    if (numberA < 100)
    {
        Console.WriteLine("У заданного числа нет 3 цифры");
    }
    else
    {
        if (numberA > 99 && numberA < 1000) Console.WriteLine((numberA % 100) % 10);
        if (numberA > 999 && numberA < 10000) Console.WriteLine(((numberA % 1000) % 100) / 10);
        if (numberA > 9999 && numberA < 100000) Console.WriteLine(((numberA % 10000) % 1000) / 100);
        if (numberA > 99999 && numberA < 1000000) Console.WriteLine(((numberA % 100000) % 10000) / 1000);
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
            if (NumDay == 7) Console.WriteLine("Воскресенье выходной день");
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

void Zadacha7() //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
{
    Console.WriteLine("Введите любое пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = number / 10000;
    int number2 = (number / 1000) % 10;
    int number3 = (number / 10) % 10;
    int number4 = number % 10;
    int number5 = (number / 100) % 10; // 3-я "средняя" цифра
    if (number > 99999 || number < 10000) 
    {
        Console.WriteLine("Неверный ввод");
    }
    else if (number1 == number4 && number2 == number3)
    {
        Console.WriteLine($"Число является палиндромом {number} = {number}");
    }
    else
    {
        Console.WriteLine("Введеное число не является палиндромом: ");
        Console.Write($"число {number} != {number4}{number3}{number5}{number2}{number1}");
    }
}

void Zadacha8() //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
{
    Console.WriteLine("Введите x1");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите x2");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите x3");
    int x3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y1");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y2");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y3");
    int y3 = Convert.ToInt32(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(x3 - y3, 2));
    Console.WriteLine(result);
}

void Zadacha9() //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    int start = 1;
    while (start <= a)
    {
        Console.WriteLine(Math.Pow(start, 3));
        start++;
    }
}

void Zadacha10() //Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = number / 100;
    int number2 = (number / 10) % 10;
    int number3 = number % 10;
    int sum = number1 + number2 + number3;
    if (sum % 3 == 0)
    {
        Console.WriteLine($"Сумма чисел равна {sum} и делится на 3");
    }
    else
    {
        Console.WriteLine($"Сумма чисел не равна {sum} и делится на 3");
    }
}

void Zadacha11() //Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = number / 100;
    int number2 = (number / 10) % 10;
    int number3 = number % 10;
    if ((number1 == 4 || number2 == 4 || number3 == 4) && (number1 == 7 || number2 == 7 || number3 == 7))
    {
        Console.WriteLine($"в числе {number} есть цифра 4 и цифра 7");
    }
    else if (number1 == 4 || number2 == 4 || number3 == 4) Console.WriteLine($"в числе {number} есть только цифра 4");
    else if (number1 == 7 || number3 == 7 || number3 == 7) Console.WriteLine($"в числе {number} есть только цифра 7");
    else
    {
        Console.WriteLine($"в числе {number} нет цифры 4 и цифры 7");
    }
}

void Zadacha12() //Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
{
    int[] array = new int[10];
    int i = 0;
    while (i < 10)
    {
        array[i] = i + 1;
        i++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", array)); 
}
Zadacha12();
// Задачи "Заvoidены")))