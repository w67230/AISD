﻿using AISD;

String input = "";

while (true)
{
    while (Statyki.lab < 1 || Statyki.lab > Statyki.getLiczbaLaboratoriow())
    {
        Console.WriteLine("Podaj numer laboratoriow");
        input = Console.ReadLine();
        try
        {
            Statyki.lab = Convert.ToInt32(input);
        }
        catch (Exception)
        {
            Console.WriteLine("Podaj poprawny numer");
        }
    }

    while (Statyki.nr < 1 || Statyki.nr > Statyki.GetLiczbaZadan(Statyki.lab))
    {
        Console.WriteLine("Podaj numer zadania");
        input = Console.ReadLine();
        try
        {
            Statyki.nr = Convert.ToInt32(input);
        }
        catch (Exception)
        {
            Console.WriteLine("Podaj poprawny numer");
        }
    }

    if(Statyki.lab == 1)
    {
        switch(Statyki.nr){
            case 1: AISD.Lab01.Zad1.Run(); break;
            case 2: AISD.Lab01.Zad2.Run(); break;
            case 3: AISD.Lab01.Zad3.Run(); break;
            case 4: AISD.Lab01.Zad4.Run(); break;
            case 5: AISD.Lab01.Zad5.Run(); break;
            default: break;

        }
    }
    else if(Statyki.lab == 2)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab02.Zad1.Run(); break;
            case 2: AISD.Lab02.Zad2.Run(); break;
            case 3: AISD.Lab02.Zad3.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 3)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab03.Zad1.Run(); break;
            case 2: AISD.Lab03.Zad2.Run(); break;
            case 3: AISD.Lab03.Zad3.Run(); break;
            case 4: AISD.Lab03.Zad4.Run(); break;
            case 5: AISD.Lab03.Zad5.Run(); break;
            case 6: AISD.Lab03.Zad6.Run(); break;
            case 7: AISD.Lab03.Zad7.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 4)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab04.Zad1.Run(); break;
            case 2: AISD.Lab04.Zad2.Run(); break;
            case 3: AISD.Lab04.Zad3.Run(); break;
            case 4: AISD.Lab04.Zad4.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 5)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab05.Zad1.Run(); break;
            case 2: AISD.Lab05.Zad2.Run(); break;
            case 3: AISD.Lab05.Zad3.Run(); break;
            case 4: AISD.Lab05.Zad4.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 6)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab06.Zad1.Run(); break;
            case 2: AISD.Lab06.Zad2.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 7)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab07.Zad1.Run(); break;
            case 2: AISD.Lab07.Zad2.Run(); break;
            case 3: AISD.Lab07.Zad3.Run(); break;
            case 4: AISD.Lab07.Zad4.Run(); break;
            case 5: AISD.Lab07.Zad5.Run(); break;
            case 6: AISD.Lab07.Zad6.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 8)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab08.Zad1.Run(); break;
            case 2: AISD.Lab08.Zad2.Run(); break;
            case 3: AISD.Lab08.Zad3.Run(); break;
            case 4: AISD.Lab08.Zad4.Run(); break;
            case 5: AISD.Lab08.Zad5.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 9)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab09.Zad1.Run(); break;
            case 2: AISD.Lab09.Zad2.Run(); break;
            case 3: AISD.Lab09.Zad3.Run(); break;
            case 4: AISD.Lab09.Zad4.Run(); break;
            default: break;

        }
    }
    else if (Statyki.lab == 10)
    {
        switch (Statyki.nr)
        {
            case 1: AISD.Lab10.Zad1.Run(); break;
            case 2: AISD.Lab10.Zad2.Run(); break;
            case 3: AISD.Lab10.Zad3.Run(); break;
            case 4: AISD.Lab10.Zad4.Run(); break;
            case 5: AISD.Lab10.Zad5.Run(); break;
            default: break;

        }
    }
    else
    {
        Console.WriteLine("jak?");
    }


    if(Statyki.nr >= Statyki.GetLiczbaZadan(Statyki.lab))
    {
        break;
    }
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Jeśli chcesz uruchomić kolejne zadanie, wpisz: t");
    input = Console.ReadLine();

    if (input == "t")
    {
        Statyki.nr++;
        Console.WriteLine("Uruchomiono kolejne zadanie:");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    else break;

}





