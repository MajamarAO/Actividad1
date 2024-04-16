using System;

class Program
{
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
    public static void Main()
    {
      //ciframos
      Console.WriteLine("Ingrese la frase a cifrar");
        string msj = Console.ReadLine();
      
        while (string.IsNullOrEmpty(msj))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            msj = Console.ReadLine();
        }
      Console.WriteLine("Ingrese la distancia");
      string input = Console.ReadLine();
        Program program = new Program();
      
        string msjcif = CifradoCesar7(msj);
        Console.WriteLine("Mensaje cifrado: " + msjcif);

      //desciframos
      Console.WriteLine("Ingrese la frase a descifrar");
        string msjd = Console.ReadLine();

        while (string.IsNullOrEmpty(msjd))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            msjd = Console.ReadLine();
        }

        string msjdcif = desCifradoCesar7(msjd);
        Console.WriteLine("Mensaje descifrado: " + msjdcif);
    }

    static string CifradoCesar7(string mensaje)
    {
        string mensajeCifrado = "";
        foreach (char letra in mensaje)
        {
            int indice = alfabeto.IndexOf(letra);
            char letraCifrada = alfabeto[(indice + 7) % alfabeto.Length];
            mensajeCifrado += letraCifrada;

        }
        return mensajeCifrado;
    }
  static string desCifradoCesar7(string mensaje)
  {
      string mensajeCifrado = "";
      foreach (char letra in mensaje)
      {
          int indice = alfabeto.IndexOf(letra);
          char letraCifrada = alfabeto[(indice - 7 + alfabeto.Length) % alfabeto.Length];
          mensajeCifrado += letraCifrada;

      }
      return mensajeCifrado;
  }
}