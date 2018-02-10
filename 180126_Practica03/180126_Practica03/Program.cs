using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180126_Practica03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona la opcion: \n1. Numero \n2. Email\n3. Numero telefonico");
            int opc = Convert.ToInt32(Console.ReadLine());
        }
    }

    public class FormField
    {
        public bool isValid { get; set; }
        public string value { get; set; }
        public IValidable validationType { get; set; }
        
        public bool Validate()
        {
            validationType.();
        }
    }

    public class StringField : FormField
    {

    }

    public class NumberField : FormField
    {

    }

    public class Vali

    public interface IValidable
    {
        0
    }
}
