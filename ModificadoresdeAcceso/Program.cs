using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresdeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
                = new Cliente();

            cliente.Nombre = "\n El Pinky\n\t";
            cliente.Telefono = "\n 6441537226\n\t";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telefono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "\n 12345678912345\n\t";
                Console.WriteLine("Curp: " + cliente.Curp);

            }
            catch (Exception e)
            {
                Console.WriteLine("La CURP debe ser de 18 caracteres");
            }
          
            Console.Read();

        }
    }
}
