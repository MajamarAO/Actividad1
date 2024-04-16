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
      int dist;
      while (!int.TryParse(Console.ReadLine(), out dist) || dist <= 0)
      {
          Console.WriteLine("Por favor ingrese un entero válido:");
      }

        string msjcif = CifradoCesar(msj, dist);
        Console.WriteLine("Mensaje cifrado: " + msjcif);

      //desciframos
      Console.WriteLine("Ingrese la frase a descifrar");
        string msjd = Console.ReadLine();

        while (string.IsNullOrEmpty(msjd))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            msjd = Console.ReadLine();
        }
      Console.WriteLine("Ingrese la distancia");
      int distd;
      while (!int.TryParse(Console.ReadLine(), out distd) || distd <= 0)
      {
          Console.WriteLine("Por favor ingrese un entero válido:");
      }

        string msjdcif = desCifradoCesar(msjd, distd);
        Console.WriteLine("Mensaje descifrado: " + msjdcif);
    }

    static string CifradoCesar(string mensaje, int distancia)
    {
        string mensajeCifrado = "";
        foreach (char letra in mensaje)
        {
            int indice = alfabeto.IndexOf(letra);
            char letraCifrada = alfabeto[(indice + distancia) % alfabeto.Length];
            mensajeCifrado += letraCifrada;

        }
        return mensajeCifrado;
    }
  static string desCifradoCesar(string mensaje, int distancia)
  {
      string mensajeCifrado = "";
      foreach (char letra in mensaje)
      {
          int indice = alfabeto.IndexOf(letra);
          char letraCifrada = alfabeto[(indice - distancia + alfabeto.Length) % alfabeto.Length];
          mensajeCifrado += letraCifrada;

      }
      return mensajeCifrado;
  }
}