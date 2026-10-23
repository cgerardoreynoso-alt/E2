
using System;

class Program
{
    // 1. Definir una función
    static void Saludar()
    {
        Console.WriteLine("Hola");
    }

    static void Main()
    {
        // Ejercicio 1: Invocar la función
        Saludar();

        // Ejercicio 2: Imprimir la secuencia
        int[] numeros = { 2, 4, 6, 9, 12, 15, 19, 23, 27 };

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        // Ejercicio 3: Ciclo ascendente o descendente
        int inicio = 2;
        int limite = 3;

        if (inicio * limite < 8 && inicio > limite)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(inicio - i);
            }
        }
        else
        {
            for (int i = inicio; i <= limite; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Ejercicio 4: Determinar si es múltiplo de 5
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool resultado = EsMultiplo(numero);

        Console.WriteLine($"El resultado es: {resultado}");

       
    }

    // Ejercicio 4
    static bool EsMultiplo(int numero)
    {
        if (numero % 5 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    
}
