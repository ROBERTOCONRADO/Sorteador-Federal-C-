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
            //LOGICA
            //Quando o número sorteado é acima ou igual a 60000 acredito "eu" que a probabilidade que no próximo sorteio, ele seja abaixo desse valor.
            //A mesma lógica segue quando o número sorteado é igual ou abaixo de 40000.
            //Na solução números sequenciais seguidos também são eliminados.
            int ultimoSortFederal = 88869;
            int menos10 = ultimoSortFederal - 10000;
            Random random = new Random();
            int num = random.Next(000000, 100001);
            string numString = num.ToString();
            int digito1 = int.Parse(numString[0].ToString());//8
            int digito2 = int.Parse(numString[1].ToString());//8
            int digito3 = int.Parse(numString[2].ToString());//8
            int digito4 = int.Parse(numString[3].ToString());//6
            int digito5 = int.Parse(numString[4].ToString());//9
            if (num >= menos10 || digito1 == digito2 || digito2 == digito3 || digito3 == digito4 || digito4 == digito5 || digito1 == digito5 || digito2 == digito4 || (digito1 >= 8) || (digito2 >= 8) || (digito3 >= 8) || (digito5 >=9)) 
            {
                Console.WriteLine($"Caiu no primeiro if num: {num}");
                Random random2 = new Random();
                int num2 = random.Next(000000, 100001);
                string num2String = num2.ToString();
                int digito1n2 = int.Parse(num2String[0].ToString());
                int digito2n2 = int.Parse(num2String[1].ToString());
                int digito3n2 = int.Parse(num2String[2].ToString());
                int digito4n2 = int.Parse(num2String[3].ToString());
                int digito5n2 = int.Parse(num2String[4].ToString());
                if (num2 >= menos10 || digito1n2 == digito2n2 || digito2n2 == digito3n2 || digito3n2 == digito4n2 || digito4n2 == digito5n2 || digito1n2 == digito5n2 || digito2n2 == digito4n2 || (digito1n2 >= 8) || (digito2n2 >= 8) || (digito3n2 >= 8) || (digito5n2 >= 9))
                {
                    Console.WriteLine($"Caiu no segundo if num: {num2}"); 
                    Random random3 = new Random();
                    int num3 = random.Next(000000, 100001);
                    string num3String = num3.ToString();
                    int digito1n3 = int.Parse(num3String[0].ToString());
                    int digito2n3 = int.Parse(num3String[1].ToString());
                    int digito3n3 = int.Parse(num3String[2].ToString());
                    int digito4n3 = int.Parse(num3String[3].ToString());
                    int digito5n3 = int.Parse(num3String[4].ToString());         
                    if (num3 >= menos10 || digito1n3 == digito2n3 || digito2n3 == digito3n3 || digito3n3 == digito4n3 || digito4n3 == digito5n3 || digito1n3 == digito5n3 || digito2n3 == digito4n3 || (digito1n3 >= 8) || (digito2n3 >= 8) || (digito3n3 >= 8) || (digito5n3 >= 9)) 
                    {
                        Console.WriteLine($"Caiu no terceiro if num: {num3}");
                        Random random4 = new Random();
                        int num4 = random.Next(000000, 100001);
                        string num4String = num4.ToString();
                        int digito1n4 = int.Parse(num4String[0].ToString());
                        int digito2n4 = int.Parse(num4String[1].ToString());
                        int digito3n4 = int.Parse(num4String[2].ToString());
                        int digito4n4 = int.Parse(num4String[3].ToString());
                        int digito5n4 = int.Parse(num4String[4].ToString());                         
                        if (num4 >= menos10 || digito1n4 == digito2n4 || digito2n4 == digito3n4 || digito3n4 == digito4n4 || digito4n4 == digito5n4 || digito1n4 == digito5n4 || digito2n4 == digito4n4 || (digito1n4 >= 8) || (digito2n4 >= 8) || (digito3n4 >= 8) || (digito5n4 >= 9))
                        {
                            int numeroFinal = num4 / 2;
                            Console.WriteLine($"Caiu no quarto if num: {numeroFinal}");
                        } else Console.WriteLine($"Este é o resultado do quarto sorteio: {num4}");
                    } else Console.WriteLine($"Este é o resultado do terceiro sorteio: {num3}");
                } else Console.WriteLine($"Este é o resultado do segundo sorteio: {num2}");
            } else Console.WriteLine($"Este é o resultado do primeiro sorteio: {num}");
            Console.ReadLine();
        }
    }
}