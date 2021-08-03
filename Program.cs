using System;

namespace DAM_1
{
    class Program
    {
        static void Main(string[] args)
        {


            █╗  ██╗ ██████╗ ██╗      █████╗      █████╗ ███╗   ███╗██╗ ██████╗  ██████╗ ███████╗
██║  ██║██╔═══██╗██║     ██╔══██╗    ██╔══██╗████╗ ████║██║██╔════╝ ██╔═══██╗██╔════╝
███████║██║   ██║██║     ███████║    ███████║██╔████╔██║██║██║  ███╗██║   ██║███████╗
██╔══██║██║   ██║██║     ██╔══██║    ██╔══██║██║╚██╔╝██║██║██║   ██║██║   ██║╚════██║
██║  ██║╚██████╔╝███████╗██║  ██║    ██║  ██║██║ ╚═╝ ██║██║╚██████╔╝╚██████╔╝███████║
╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝ ╚═════╝  ╚═════╝ ╚══════╝
            //Declaro las variables y matrices
            

            int indice1=0, indice2=0,indice3=0,indice4=0;
            int[,] matriz1,matriz2;
            bool datosCorrectos = false;
            bool matrizIguales = true;
            /*Manejo el fallo con try y utilizo un bucle para que tenga que introducir los
            datos bien obligatoriamente. Esto es para la primera matriz */

            do
            {
                try
                {
                    //Pedir a usuario que ponga las dimensiones de cada matriz
                    Console.WriteLine("Para indicar las filas de la primera matriz, por favor, introduce sólamente un número de tipo entero");
                    indice1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Número introducido {indice1}\n-Introduce las columnas de la matriz");
                    indice2 = int.Parse(Console.ReadLine());
                    matriz1 = new int[indice1, indice2];
                    Console.WriteLine("Introduce el número de filas de la segunda matriz. Recuerde que los datos que debe introducir son de tipo enteros.");
                    indice3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el número de columnas de la segunda matriz");
                    indice4 = int.Parse(Console.ReadLine());
                    matriz2 = new int[indice3, indice4];
                    //Ahora se le pedirá al usuario que rellene los elementos de las matrices
                    for (int i = 0; i < indice1; i++)
                    {
                        for (int j = 0; j < indice2; j++)
                        {
                            Console.WriteLine("Introduce el valor de la fila " + (i + 1) + ",columna " + (j + 1) + " de la primera matriz.");
                            matriz1[i, j] = int.Parse(Console.ReadLine());
                        }

                    }

                    Console.WriteLine("Ahora introduce valores para la seguna matriz");
                    for (int i = 0; i < indice3; i++)
                    {
                        for (int j = 0; j < indice4; j++)
                        {
                            Console.WriteLine("Introduce el valor de la fila " + (i + 1) + ",columna " + (j + 1) + " de la segunda matriz.");
                            matriz2[i, j] = int.Parse(Console.ReadLine());
                        }

                    }
                    /*Si el usuario ha introducido números enteros, este boolean permitirá salir
                    una vez se hayan ejecutado todos los datos*/
                    datosCorrectos = true;


                    /*Ahora vamos a hacer que se impriman por pantalla las dos matrices
                    en forma de tablas para que todo esté más claro. */

                    //Lectura de la primera matriz
                    for (int i = 0; i < indice1; i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j < indice2; j++)
                        {
                            Console.Write(matriz1[i, j] + " ");
                        }
                    }
                    //Lectura de la segunda matriz y salto de línea para que no se junten las dos tablas
                    Console.WriteLine();

                    for (int i = 0; i < indice3; i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j < indice4; j++)
                        {
                            Console.Write(matriz2[i, j] + " ");
                        }
                    }
                    //Ahora vamos a ver si se pueden comparar las dos matrices introducidas por el usuario

                    if (matriz1.Length == matriz2.Length)
                    {
                        Console.WriteLine("\n\nLas matrices pueden ser comparadas");
                        //Bucle para ver si las matrices tienen el mismo valor.
                        for (int i = 0; i < indice1; i++)
                        {
                            for (int j = 0; j < indice2 && matrizIguales; j++)
                            {
                                if (matriz1[i, j] != matriz2[i, j])
                                {
                                    matrizIguales = false;
                                }

                            }
                        }
                        if (matrizIguales)
                            Console.WriteLine("Las matrices son iguales");
                        else
                            Console.WriteLine("Las matrices no son iguales");
                    }
                    else
                        Console.WriteLine("\n\nLas matrices no pueden ser comparadas");
                }
                catch (OverFlowException ex)
                {
                    Console.WriteLine("El dato introducido tiene un rango que sobrepasa un int. Inténtalo de nuevo.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido un formato incorrecto. Debes introducir un número de tipo int");
                }
                
            } while (!datosCorrectos);


           
         
        }
    }
}
