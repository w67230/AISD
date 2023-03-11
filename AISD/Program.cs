
String input = "";
int lab = 0;
int nr = 0;

while (true)
{
    while (lab < 1 || lab > AISD.Statyki.getLiczbaLaboratoriow())
    {
        Console.WriteLine("Podaj numer laboratoriow");
        input = Console.ReadLine();
        try
        {
            lab = Convert.ToInt32(input);
        }
        catch (Exception)
        {
            Console.WriteLine("Podaj poprawny numer");
        }
    }

    while (nr < 1 || nr > AISD.Statyki.GetLiczbaZadan(lab))
    {
        Console.WriteLine("Podaj numer zadania");
        input = Console.ReadLine();
        try
        {
            nr = Convert.ToInt32(input);
        }
        catch (Exception)
        {
            Console.WriteLine("Podaj poprawny numer");
        }
    }

    if(lab == 1)
    {
        switch(nr){
            case 1: AISD.Lab01.Zad1.Run(); break;
            case 2: AISD.Lab01.Zad2.Run(); break;
            case 3: AISD.Lab01.Zad3.Run(); break;
            case 4: AISD.Lab01.Zad4.Run(); break;
            case 5: AISD.Lab01.Zad5.Run(); break;
            default: break;

        }
    }
    else if(lab == 2)
    {
        Console.WriteLine("Jeszcze nie bylo drugich labow");
    }
    else
    {
        Console.WriteLine("jak?");
    }


    if(nr >= AISD.Statyki.GetLiczbaZadan(lab))
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
        nr++;
        Console.WriteLine("Uruchomiono kolejne zadanie:");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    else break;

}





