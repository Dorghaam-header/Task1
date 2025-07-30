void readNumberOfCarmet()
{
    //output
    Console.WriteLine("Welcome To Eslam Carpet Washing");
    Console.WriteLine("________________________________");
    Console.WriteLine("The Price of the { Larg Carpet = $35 }");
    Console.Write('\n');
    Console.WriteLine("The Price of the { Small Carpet = $25 }");
    Console.WriteLine("________________________________");
    Console.WriteLine("Oh, There is a 6% tax .");
    Console.Write('\n');

    //input
    Console.Write("Now..how many larg Carpets do you want to wash ?:  ");
    int Larg = Convert.ToInt32(Console.ReadLine());
    Console.Write('\n');
    Console.Write("Okay and how many small Carpets do you want to wash ?:  ");
    int Small = Convert.ToInt32(Console.ReadLine());
    Console.Write('\n');

    //calculate
    int Totall = Small *25 + Larg *35 ;

    Console.WriteLine($"Totall = ${Totall}");
    Console.Write('\n');

    double Tax = ( Small *25 + Larg *35) *1.06 - Totall ;

    Console.WriteLine($"Tax = ${Tax}");
    Console.Write('\n');
    Console.WriteLine($"Totall Amount Tax = ${Tax+Totall}");

    


}

readNumberOfCarmet();