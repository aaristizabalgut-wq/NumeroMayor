using System;
/*Este programa Crea un arreglo de 7 números.
Permite que el usuario los ingrese.
Muestra el número mayor.*/
class Program
{
    static void Main()
    {
        int[] numeros = new int[7];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingresa el número ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int mayor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
    }
}