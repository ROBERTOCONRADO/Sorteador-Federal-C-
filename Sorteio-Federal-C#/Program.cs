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
      int valorSorteado = 94456;
      string[] allStrings = new string[20];

      for (int i = 0; i < 20; i++) {
          int num = 0;
          string numString = "";

          do {
              Random random = new Random();
              num = random.Next(0, 100001);
              numString = num.ToString().PadLeft(5, '0');

              int digito1 = int.Parse(numString[0].ToString());
              int digito2 = int.Parse(numString[1].ToString());
              int digito3 = int.Parse(numString[2].ToString());
              int digito4 = int.Parse(numString[3].ToString());
              int digito5 = int.Parse(numString[4].ToString());

              bool haNumerosDuplicados = (digito1 == digito2 || digito2 == digito3 || digito3 == digito4 || digito4 == digito5 || digito1 == digito5 || digito2 == digito4);
              bool haDigitosExcluidos = (digito1 >= 8 || digito2 == 4 || digito3 == 4 || digito4 == 5 || digito5 == 6);

              if (num + 10000 >= valorSorteado || haNumerosDuplicados || haDigitosExcluidos) {
                  continue;
              }
              break;
          } while (true);

          allStrings[i] = numString;
      }

      // Exibir todas as strings armazenadas na array
      Console.WriteLine("\nNúmeros Gerados:");
      for (int i = 0; i < 20; i++) {
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
32098
53541
61703
01265
02045
58943
29783
32135
62614
68674
75062
61628
69834
17892
25181
42380
67608
28793
47943
76505
*/
