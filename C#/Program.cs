using System;
using System.IO;


namespace Icoltrans
{
    class Program
    {
          
        static void Main(string[] args)
        {
          
            //Programa que capture los datos ingresados por mi padre y los muestre por medio de una pagina html
            // Fecha, Vehiculos, Manifiesto, Total Cajas, Cliente, Hora Inicio, Hora Final, Auxiliar, Braseros.

            string fecha, vehiculos, manifiesto, cliente, auxiliar, hora_inicio, hora_final;
            int total_cajas, braseros;
            int opcion1;
            //el programa creara una carpeta dentro del disco "C:" con el siguiente nombre
            string ruta = "C:\\IcoltransGerzon";

                do
            {
                Console.Clear();
                Console.WriteLine("_________________TABLA DE ESTADÍSTICAS__________________");

                Console.Write("Ingrese la Fecha: ");
                fecha = Console.ReadLine();
                Console.Write("Ingrese la placa del vehiculo: ");
                vehiculos = Console.ReadLine();
                Console.Write("Manifiesto: ");
                manifiesto = Console.ReadLine();
                Console.Write("Digite el total de cajas: ");
                total_cajas = int.Parse(Console.ReadLine());
                Console.Write("Digite el nombre del cliente: ");
                cliente = Console.ReadLine();
                Console.Write("Ingrese la hora de inicio: ");
                hora_inicio = Console.ReadLine();
                Console.Write("Ingrese la hora final: ");
                hora_final = Console.ReadLine();
                Console.Write("Digite el nombre del auxiliar: ");
                auxiliar = Console.ReadLine();
                Console.Write("Digite la cantidad de braseros: ");
                braseros = int.Parse(Console.ReadLine());
                // revisar si la carpeta existe
                if (Directory.Exists(ruta) == false) 
                {
                    Directory.CreateDirectory(ruta);

                }
                // creacion de pagina html donde se mostraran los campos que digite 
                string cuerpo = "<html>" +
                    "<head>" +
                    "<center>TABLA DE ESTADISTICAS</center>" +
                    "</head>" +
                    "<body>" +
                    "<table border='1'><tr><th>Fecha</th><td>" + fecha +
                    "</td></tr><tr><th>Vehiculos</th><td>" + vehiculos +
                    "</td></tr><tr><th>Manifiesto</th><td>" + manifiesto +
                    "</td></tr><tr><th>Total De Cajas</th><td>" + total_cajas +
                    "</td></tr><tr><th>Cliente</th><td>" + cliente +
                    "</td></tr><tr><th>Hora De Inicio</th><td>" + hora_inicio +
                    "</td></tr><tr><th>Hore Final</th><td>" + hora_final +
                    "</td></tr><tr><th>Auxiliar</th><td>" + auxiliar +
                    "</td></tr><tr><th>Braseros</th><td>" + braseros +

                    "</td></tr></table></body>" +
                    "</html>";
                //nombre del archivo .html
                File.WriteAllText("C:\\IcoltransGerzon\\" + vehiculos + ".html", cuerpo);



                    Console.Clear();
                    Console.WriteLine("Ingrese una opción");
                    Console.WriteLine("[1] Digitar campos de una tabla nueva...");
                    Console.WriteLine("[2] Salir...");
                    Console.Write("Respuesta : ");
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Presione Enter para salir......");

            } while (opcion1 == 1);


            Console.ReadKey();
        }
    }
}