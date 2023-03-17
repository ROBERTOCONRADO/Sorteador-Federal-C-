using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Solução que recebe o último número sorteado da federal e cria um sorteio com maior porcentagem de acerto.
      int tentativas = 1000;
      int valorSorteado = 94456;
      int contador = 0;
      string[] allStrings = new string[tentativas];

      do {
          Random random = new Random();
          int num = random.Next(0, 100001);
          string numString = num.ToString().PadLeft(5, '0');
          int digito1 = int.Parse(numString[0].ToString());
          int digito2 = int.Parse(numString[1].ToString());
          int digito3 = int.Parse(numString[2].ToString());
          int digito4 = int.Parse(numString[3].ToString());
          int digito5 = int.Parse(numString[4].ToString());

          bool digitosDuplicados = (digito1 == digito2 || digito2 == digito3 || digito3 == digito4 || digito4 == digito5 || digito1 == digito5 || digito2 == digito4);
          bool digitosExcluidos = (digito1 >= 8 || digito2 == 4 || digito3 == 4 || digito4 == 5 || digito5 == 6);

          if (num + 10000 >= valorSorteado || digitosDuplicados || digitosExcluidos) {
              allStrings[contador] = numString;
              contador++;
              continue;
          }
          allStrings[contador] = numString;
          Console.WriteLine($"Número válido gerado: {numString}");
          break;
      } while (contador < tentativas);

      // Exibir todas as strings armazenadas na array
      Console.WriteLine("\nTodas as strings geradas:");
      for (int i = 0; i < contador; i++) {
          Console.WriteLine(allStrings[i]);
      }
    }
  }
}
/*
Alguns números gerados com a solução:
01248
06718
10617
21584
27264
42731
48249
59708
60624
65871
79573
29020
*/
