namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while ((choice != 1) && (choice != 2) && (choice != 3))
            {
                Console.WriteLine("********************************************");
                Console.Write("\n");
                Console.WriteLine("Välkomen till flygtidsberäknaren!");
                Console.Write("\n");
                Console.WriteLine("Vilket flyg vill du se detaljerad information om? (Svara med en siffra)");

                Console.WriteLine("1. Stockholm - New York");
                Console.WriteLine("2. New York - Stockholm");
                Console.WriteLine("3. Avsluta programmet");
                Console.Write("Skriv ditt val här: ");

                choice = Convert.ToInt32(Console.ReadLine());
            }

            TimeSpan timeSpanNY = new TimeSpan(10, 10, 00); //Avgångstiden från New York är 10:10
            
            TimeSpan timeSpanSthlm = new TimeSpan(14, 3, 00);  //Avgångstiden från Stockholm är 14:03
            
            TimeSpan timeDifference = new TimeSpan(6, 00, 00);  //Tidsskillnaden är 6 timmar
            
            TimeSpan FlightTime = new TimeSpan(7, 25, 00); //Det tar 7 timmar och 25 minuter att flyga sträckan enkel resa


            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    TimeSpan arrivalTimeNY = timeSpanSthlm - timeDifference + FlightTime;
                    string formatedString = arrivalTimeNY.ToString(@"hh\:mm");
                    string formatedString2 = timeSpanSthlm.ToString(@"hh\:mm");
                   
                    Console.Write("\n");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("\n");
                    Console.WriteLine($"Avgångstiden från Stockholm är: " + formatedString2);
                    Console.WriteLine("Ankomsttiden i New York är: " + formatedString);
                    Console.WriteLine("\n");
                    Console.WriteLine("****************************************");

                    break;



                case 2:
                    Console.WriteLine("");
                    TimeSpan arrivaltimeSthlm = timeSpanNY + timeDifference + FlightTime;
                    formatedString = arrivaltimeSthlm.ToString(@"hh\:mm");
                    string formatedString3 = timeSpanNY.ToString(@"hh\:mm");                   
                    
                    Console.Write("\n");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("\n");
                    Console.WriteLine("Avgångstiden från New York är: " + formatedString3);
                    Console.WriteLine("Ankomsttid till Stockholm: " + formatedString);
                    Console.WriteLine("\n");
                    Console.WriteLine("****************************************");

                    break;


                case 3: Console.WriteLine("Programmet har avslutats"); break;


            }
        }
    }
}
