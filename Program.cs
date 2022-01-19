using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace Prueba_Megatone
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Celular celular = new Celular("MOTOROLA", "7 E I POWER", "Almacenamiento. 32 GB. Memoria. 2GB", 21000);
           celular.AgregarCelular();
           celular.BuscarCelular("MOTOROLA", "7 E I POWER", "21000");
            
            
        }
    }
}
