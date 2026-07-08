using System;
public class Program
{
    public static void Main(string[] args)
    {
        
        //Declaracion de arreglos
        int[] codigo = new int[20];
        string[] nombre = new string[20];
        double[] precio = new double[20];
        int[] stock = new int[20];

        //Declaración de variable
        int contadordeProductos = 0;
        string opcionMenu;

        //Proceso


        do
        {
        Console.WriteLine("1: Registrar un producto");
        Console.WriteLine("2: Mostrar el catálogo completo");
        Console.WriteLine("3: Buscar un producto por código");
        Console.WriteLine("4: Actualizar el stock");
        Console.WriteLine("5: Ordenar el catálogo por precio");
        Console.WriteLine("6: Insertar un producto en una posición específica");
        Console.WriteLine("7: Eliminar un producto por código");
        Console.WriteLine("8: Ordenar el catálogo por nombre");
        Console.WriteLine("9: Demostración: parámetro por valor vs. por referencia");
        Console.WriteLine("0: Salir del programa"); 

        Console.WriteLine("Ingrese una opción");
        opcionMenu = Console.ReadLine();

            switch (opcionMenu)
            {
                case "1":
                Console.WriteLine("qué hacer si eligió Registrar producto");
                break;

                case "2":
                Console.WriteLine("qué hacer si eligió Mostrar catálogo completo");
                break;

                case "3":
                Console.WriteLine("qué hacer si eligió Buscar un producto por código");
                break;

                case "4":
                Console.WriteLine("qué hacer si eligió Actualizar el stock");
                break;

                case "5":
                Console.WriteLine("qué hacer si eligió Ordenar el catálogo por precio");
                break;

                case "6":
                Console.WriteLine("qué hacer si eligió Insertar un producto en una posición específica");
                break;

                case "7":
                Console.WriteLine("qué hacer si eligió Eliminar un producto por código");
                break;

                case "8":
                Console.WriteLine("qué hacer si eligió Ordenar el catálogo por nombre");
                break;

                case "9":
                Console.WriteLine("qué hacer si eligió Demostración: parámetro por valor vs. por referencia");
                break;

                case "0":
                Console.WriteLine("qué hacer si eligió Salir del programa");
                break;

                default:
                Console.WriteLine("qué pasa si escribió algo que no es 0-9");
                break;

            }
        
        }while (opcionMenu !="0");













    }
    
}

