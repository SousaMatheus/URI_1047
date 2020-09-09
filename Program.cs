using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, duracaoH, duracaoM;

            string [] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);
                //duracao de 24h
            if (horaInicial == horaFinal && minutoInicial == minutoFinal){
                Console.ReadLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (horaFinal > horaInicial && minutoFinal > minutoInicial){
                duracaoH = horaFinal - horaFinal;
                duracaoM = minutoFinal - minutoInicial;
                Console.ReadLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            else if (horaFinal > horaInicial && minutoFinal == minutoInicial){
                duracaoH = horaFinal - horaFinal;
                duracaoM = 0;
                 Console.ReadLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            else if ( horaFinal == horaInicial && minutoFinal > minutoInicial){
                duracaoH = 0;
                duracaoM = minutoFinal - minutoFinal;
                Console.ReadLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            
            





        }
    }
}
