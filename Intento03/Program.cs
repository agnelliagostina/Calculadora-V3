namespace Intento03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "CALCULADORA";
            //Introduce el primer valor
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese un valor:");
            string valorUno;
            Console.ResetColor();
            valorUno = Console.ReadLine();
            float valorIngresado1 = float.Parse(valorUno);


            //Introduce el segundo valor
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese el segundo valor:");
            string valorDos;
            Console.ResetColor();
            valorDos = Console.ReadLine();
            float valorIngresado2 = float.Parse(valorDos);

            ////Introduce la operación a realizar
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ingrese operación a realizar: +,-,* ó /");
            string operacion;
            Console.ResetColor();
            operacion = Console.ReadLine();
            Console.Clear();

            //Realiza la operación indicada y muestra el resultado en pantalla
            Console.WriteLine("Resultado:");
            Console.ForegroundColor = ConsoleColor.Green;

            if (operacion == "+")
            {
                Console.WriteLine(valorIngresado1 + valorIngresado2);
            }
            else if (operacion == "-")
            {
                Console.WriteLine(valorIngresado1 - valorIngresado2);
            }
            else if (operacion == "*")
            {
                Console.WriteLine(valorIngresado1 * valorIngresado2);
            }
            else if (operacion == "/")
            {
                if (valorIngresado2 > 0)
                    Console.WriteLine(valorIngresado1 / valorIngresado2);
                else
                {
                    Console.WriteLine("Error: el segundo valor ingresado debe ser mayor a 0");
                }
            }
            else
            {
                Console.WriteLine("Operación no válida");
            }
            Console.ResetColor(); 
        }
    }         
}
