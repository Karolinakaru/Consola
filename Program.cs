// See https://aka.ms/new-console-template for more information

Console.Title = "Tytuł pierwszej storny";
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Hello, World!");
Console.Write("nie ma nowej linijki 1 ");
Console.Write("jeszcze raz nie ma linijki 2");
Console.ResetColor();
Console.ReadKey();
Console.Clear();

Console.Title = "Tytuł drugiej storny";
Console.WriteLine("Hello, again!");
Console.Write("naciśnij coś aby przejść do kolejnej strony");
Console.ReadKey();
Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Teraz nowa linijka 3");

Console.Title = "Tytuł trzeciej storny";
Console.Write("naciśnij coś aby przejść do kolejnej strony");
Console.ReadKey();
Console.ResetColor();
Console.Clear();

Console.Title = "The end";
Console.WriteLine("kolejna nowa linijka 4");
Console.Write("Wciskaj cokolwiek to zamknie się program");
Console.ReadKey();