using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
           

           string [] vet = Console.ReadLine().Split(' ');
           int horaInicial = int.Parse(vet[0]);
           int minutoInicial = int.Parse(vet[1]);
           int horaFinal = int.Parse(vet[2]);
           int minutoFinal = int.Parse(vet[3]);
            //agora vou converter as horas iniciais e finais em minutos multiplicando por 60 para poder calcular
           int instanteInicial = horaInicial * 60 + minutoInicial;
           int instanteFinal =  horaFinal * 60 + minutoFinal;
            int duracao;
           if ( instanteInicial < instanteFinal){
               duracao = instanteFinal - instanteInicial;               
           }
           else {
               duracao = (24 * 60 - instanteInicial) + instanteFinal;
           }
          int duracaoHoras = duracao / 60;
          int duracaoMinutos = duracao % 60;           
          
            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}