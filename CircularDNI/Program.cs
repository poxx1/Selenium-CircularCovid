using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDNI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Screen Logo
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.BackgroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("                                                             ");
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.BackgroundColor = ConsoleColor.White;
            System.Console.WriteLine("         SOLICITUD DE PERMISO PARA CIRCULAR POR DNI          ");
            System.Console.BackgroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("                                                             \r\n");
            System.Console.BackgroundColor = ConsoleColor.Black;
            
            Console.WriteLine("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("\r\n");

            System.Console.ForegroundColor = ConsoleColor.Cyan;
            #endregion

            SolicitarCircular p = new SolicitarCircular();

            //p.SolicitarVUELTA();
            p.SolicitarIDA();

        }
    }
}
