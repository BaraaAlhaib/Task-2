using System;

class Program
{
    static void Main()
    {
        bool running = true;

        int people = 0;
        int totalCost = 0;

        while (running)
        {
            Console.WriteLine("Välkommen till huvudmenyn!");
            Console.WriteLine("Ange ett nummer för att välja ett alternativ:");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Antal personer och totalkostnad");
            Console.WriteLine("3. Upprepa tio gånger");
            Console.WriteLine("4. Det tredje ordet");
            Console.WriteLine("0. Avsluta programmet");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Felaktig input. Var god ange en siffra.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    running = false;
                    Console.WriteLine("Programmet avslutas.");
                    break;
                case 1:
                    Console.WriteLine("Ange ålder:");
                    string ageSting = Console.ReadLine();
                    bool isNumber = int.TryParse(ageSting, out int age);

                    if (isNumber)
                    {
                        people++;
                        if (age < 20)
                        {
                            totalCost += 80;
                            Console.WriteLine("Ungdomspris: 80kr");
                        }
                        else if (age >= 65)
                        {
                            totalCost += 90;
                            Console.WriteLine("Pensionärspris: 90kr");
                        }
                        else
                        {
                            totalCost += 120;
                            Console.WriteLine("Standardpris: 120kr");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig input. Var god ange en ålder som en siffra.");
                    }
                    Console.WriteLine("___________");
                    break;
                case 2:
                    Console.WriteLine("Antal personer: " + people);
                    Console.WriteLine("Totalkostnad: " + totalCost);
                    Console.WriteLine("___________");
                    break;
                case 3:
                    Console.WriteLine("Ange en text:");
                    string input = Console.ReadLine();

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"{i + 1}. {input}");
                    }
                    Console.WriteLine("___________");
                    break;
                case 4:
                    Console.WriteLine("Ange en mening med minst 3 ord:");
                    string word = Console.ReadLine();

                    string[] words = word.Split(' ');

                    if (words.Length >= 3)
                    {
                        string thirdWord = words[2];
                        Console.WriteLine("Det tredje ordet är: " + thirdWord);
                    }
                    else
                    {
                        Console.WriteLine("Det är mindre än tre ord");
                    }
                    Console.WriteLine("___________");

                    break;
                default:
                    Console.WriteLine("Felaktigt input: Skriva mellan 1 till 4");
                    break;
            }
        }
    }
}