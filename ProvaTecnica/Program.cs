using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;

namespace ProvaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Selecione o número do modo de preparo:
                1   -   Configuração manual
                2   -   Bolo
                3   -   Frango
                4   -   Macarrão
                5   -   Patê
                6   -   Pipoca
            ");
            var modo = Console.ReadLine();
            var modoVal = Convert.ToByte(modo);
            //Console.WriteLine(modo);
            //Console.Beep(415, 1600);

            switch (modoVal)
            {
                case 1: //Configuração manual
                    Console.WriteLine("Informe o tempo de de cozimento. Minimo 1 segundo e no máximo 120 segundos.");
                    var tempo = Console.ReadLine();
                    var cozimento = Convert.ToByte(tempo);

                    if (cozimento < 1 || cozimento > 120)
                    {
                        Console.WriteLine("Tempo inválido, favor informar novamente");
                    }
                    else
                    {
                        Console.WriteLine("Informe a potência entre 1 e 10");
                        var potencia = Console.ReadLine();
                        var potenciaVal = Convert.ToByte(potencia);
                        if (potenciaVal < 1 || potenciaVal > 10)
                        {
                            Console.WriteLine("Potência inválida, favor informar novamente.");
                        }
                        else
                        {
                            Console.WriteLine("Cozimento: " + cozimento);
                            Console.WriteLine("Potência: " + potenciaVal);
                            Console.WriteLine(Prepar(cozimento, potenciaVal));
                        }
                    }
                    break;
                case 2: //Bolo
                    Console.WriteLine(Prepar(120, 120));
                    break;
                case 3: //Frango
                    Console.WriteLine(Prepar(100, 100));
                    break;
                case 4: //Macarrão
                    Console.WriteLine(Prepar(90, 90));
                    break;
                case 5: //Patê
                    Console.WriteLine(Prepar(60, 60));
                    break;
                case 6: //Pipoca
                    Console.WriteLine(Prepar(30, 30));
                    break;
            }
        }

        private static string Prepar(Int32 cozimento, Int32 potenciaVal)
        {
            for (var i = 0; i < cozimento; i++)
            {
                if (i == cozimento)
                    Console.WriteLine("Aquecida");
            }
            //foreach (var potencia in potenciaVal)
            Console.WriteLine(".");
        }
    }
}
