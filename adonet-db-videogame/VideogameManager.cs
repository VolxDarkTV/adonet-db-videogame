using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    internal static class VideogameManager
    {
        // 1 inserire un nuovo videogioco
        public static void AddData(string name, string overview, long softwareHouse)
        {
            const string conn = "Data Source=localhost;Initial Catalog=prova;Integrated Security=True";
            using SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            Console.WriteLine("Connessione Effettuata...");


            string queryName = name;

            string queryOverview = overview;

            string queryDate = DateTime.Now.ToString("dd/MM/yyyy");
           
            long querySoftwareHouseId = softwareHouse;


            string sqlQuery = $"INSERT INTO videogames(name, overview, release_date, software_house_id) VALUES ('{queryName}','{queryOverview}','{queryDate}',{querySoftwareHouseId})";

            using SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();
        }

        //2 ricercare un videogioco per id
        public static void IdSearchVideogame()
        {

        }

        //3 ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
        public static void SearchVideogame()
        {

        }

        //4 cancellare un videogioco
        public static void DeleteVideogame()
        {

        }
        //5 chiudere il programma
        public static void CloseProgram()
        {

        }
    }
}
