using _180209_Practica5.Classes;
using _180209_Practica5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _180209_Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer client = new Customer();
            client.Name = "Edgar Rodriguez";
            client.Email = "edgar@mail.com";

            PostalServiceData DHL = new PostalServiceData(5000);
            DHL.Name = "DHL";
            DHL.add(client);
            DHL.Msg = "Solo un update";
            PostalServiceData Fedex = new PostalServiceData(13000);
            Fedex.Name = "Fedex";
            Fedex.add(client);
            Fedex.Msg = "Fedex es chido";
            PostalServiceData CorreosDeMexico = new PostalServiceData(8000);
            CorreosDeMexico.Name = "Correos de Mexico";
            CorreosDeMexico.add(client);
            CorreosDeMexico.Msg = "Loading...";

            Console.ReadKey();
        }
    }
}
