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
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else if (horaFinal > horaInicial && minutoFinal > minutoInicial){
                duracaoH = horaFinal - horaInicial;
                duracaoM = minutoFinal - minutoInicial; 
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");              
            }
            else if (horaFinal > horaInicial && minutoFinal == minutoInicial){
                duracaoH = horaFinal - horaInicial;
                duracaoM = 0;                 
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            else if ( horaFinal == horaInicial && minutoFinal > minutoInicial){
                duracaoH = 0;
                duracaoM = minutoFinal - minutoInicial;    
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");           
            }
            else if ( horaFinal < horaInicial && minutoFinal > minutoInicial){
                duracaoH = 24 - horaInicial + horaFinal;
                duracaoM = minutoFinal - minutoInicial; 
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");               
            }
            else if (horaFinal < horaInicial && minutoFinal < minutoInicial){
                duracaoH = 24 - horaInicial + horaFinal - 1;                
                duracaoM = (minutoFinal + 60) - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");                 
            }       
            else if (horaFinal > horaInicial && minutoFinal < minutoInicial){
                duracaoH = horaFinal - horaInicial -1;
                duracaoM = (minutoFinal + 60) - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");  
            }       
            // seria horaFinal < horaInicial && minutoFinal == minutoInicial
            else if (horaFinal < horaInicial && minutoFinal == minutoInicial){
                duracaoH = 24 - horaInicial + horaFinal - 1;
                duracaoM = 0;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");  
            }  
            else if (horaFinal == 0 && minutoFinal > minutoInicial){
                horaFinal = 24;
                duracaoH = horaFinal - horaInicial;
                duracaoM = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            } 
            else if (horaFinal == 0 && minutoFinal < minutoInicial){
                horaFinal = 24;
                duracaoH = horaFinal - horaInicial;
                duracaoM = (minutoFinal + 60) - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            else if (horaFinal == 0 && minutoFinal == minutoInicial){
                horaFinal = 24;
                duracaoH = horaFinal - horaInicial;
                duracaoM = 0;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            else if (horaInicial == 0 && minutoFinal > minutoInicial){
                horaInicial = 24;
                 duracaoH = horaFinal - horaInicial;
                duracaoM = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }
            else if (horaInicial == 0 && minutoFinal < minutoInicial){
                horaInicial = 24;
                duracaoH = horaFinal - horaInicial;
                duracaoM = (minutoFinal + 60) - minutoInicial;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }      
            else {
                horaInicial = 24;
                duracaoH = horaFinal - horaInicial;
                duracaoM = 0;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
            }     
        }
    }
}
