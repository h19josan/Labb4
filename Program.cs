using System;
using System.Collections.Generic;

class Program
{
    static List<Person> personsList = new List<Person>();
    //Jag har använt mig av C# skolan. csharpskolan.se och av Microsoft Learn för att få tips och ideer, speciellt när jag skulle verifiera input från användaren.
    static void Main(string[] args)
    {
        bool exitProgram = false;
        //Meny delen av programmet som använder sig av en Bool för och kolla om programmet ska avslutas
        while (!exitProgram)
        {
            Console.WriteLine("Meny:");
            Console.WriteLine("1. Lägga till person");
            Console.WriteLine("2. Lista alla personer");
            Console.WriteLine("3. Avsluta programmet");

            Console.Write("Välj ett alternativ (1-3): ");
            string userInput = Console.ReadLine();
                    
            switch (userInput)
            {
                case "1":
                    AddPerson();
                    break;

                case "2":
                    ListPersons();
                    break;

                case "3":
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    static void AddPerson()
    {
        Person newPerson = new Person();

        // Läs in och verifiera data från användaren för den nya personen
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Ange kön (Kvinna/Man/IckeBinär/Annan): ");
            if (Enum.TryParse(Console.ReadLine(), out Gender gender))
            {
                newPerson.PersonGender = gender;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning för kön. Försök igen.");
            }
        }

        validInput = false;

        while (!validInput)
        {
            Console.Write("Ange hårlängd: ");
            string hairLength = Console.ReadLine();

            if (!int.TryParse(hairLength, out _)) // Kontrollera om inmatningen är en siffra, så man skriver nånting mer relevant
            {
                Console.Write("Ange hårfärg: ");
                string hairColor = Console.ReadLine();

                if (!int.TryParse(hairColor, out _)) // Kontrollera om inmatningen är en siffra, så att hårfärg blir nånting annat än en siffra
                {
                    newPerson.PersonHair = new Hair { HairLength = hairLength, HairColor = hairColor };
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning för hårfärg. Försök igen.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning för hårlängd. Försök igen.");
            }
        }

        validInput = false;

        while (!validInput)
        {
            Console.Write("Ange födelsedag (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                newPerson.BirthDate = birthDate;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Ogiltigt datumformat. Försök igen.");
            }
        }

        validInput = false;

        while (!validInput)
        {
            Console.Write("Ange ögonfärg: ");
            string eyeColor = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(eyeColor))
            {
                newPerson.EyeColor = eyeColor;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning för ögonfärg. Försök igen.");
            }
        }

        personsList.Add(newPerson);

        Console.WriteLine("Personen har lagts till.");
    }

    static void ListPersons()
    {
        Console.WriteLine("Lista över alla personer:");

        foreach (Person person in personsList)
        {
            Console.WriteLine(person.ToString());
        }
    }
}

