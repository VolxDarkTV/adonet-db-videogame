using System.Security.Cryptography;

namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t Benvenuto!");
            Console.WriteLine("\t Seleziona un operazione digitando il numero corrispondente");

            Console.WriteLine("\t (1)    inserire un nuovo videogioco");
            Console.WriteLine("\t (2)    ricercare un videogioco per id");
            Console.WriteLine("\t (3)    ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input");
            Console.WriteLine("\t (4)    cancellare un videogioco");
            Console.WriteLine("\t (5)    chiudere il programma");

            int selector = Convert.ToInt32(Console.ReadLine());

            switch (selector)
            {
                case 1: Console.WriteLine("Funzione 1");
                    bool error = false;
                    while (!error) 
                    {
                        try
                        {
                            Console.WriteLine("Nome: ");
                            string queryName = Console.ReadLine();

                            Console.WriteLine("Overview: ");
                            string queryOverview = Console.ReadLine();

                            string queryDate = DateTime.Now.ToString("dd/MM/yyyy");

                            Console.WriteLine("Software House ID: ");
                            long querySoftwareHouseId = Convert.ToInt64(Console.ReadLine());

                            VideogameManager.AddData(queryName, queryOverview, querySoftwareHouseId);

                            error = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }

                    break; 

                case 2: Console.WriteLine("Funzione 2");
                    try
                    {
                        Console.WriteLine("Inserisci l'ID del Gioco: ");
                        long id = Convert.ToInt64(Console.ReadLine());
                        VideogameManager.IdSearchVideogame(id);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                    break;

                case 3: Console.WriteLine("Funzione 3");
                    try
                    {
                        Console.WriteLine("Inserisci la Stringa: ");
                        string str = Console.ReadLine();
                        VideogameManager.SearchVideogame(str);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;

                case 4:  Console.WriteLine("Funzione 4");
                    break;

                case 5: Console.WriteLine("Funzione 5");
                    break;
            }   


        }
    }
}