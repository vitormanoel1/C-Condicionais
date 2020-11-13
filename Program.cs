using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // para participar do time de free fire o aluno precisar ter a media maior ou igual a 80
            // e faltas menor ou igual a 10 dos dias letivos.
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("bem vindo a seletiva para o time de free fire");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("voce gostaria de participar? sim ou nao");
                string resposta = Console.ReadLine();
                if(resposta == "sim"){
                Console.WriteLine("otimo! vamos analisar seu curriculo");
                Console.Write("digite sua media escolar: ");
                int media = int.Parse(Console.ReadLine());
                Console.Write("digite sua quantidade de faltas: ");
                int faltas = int.Parse(Console.ReadLine());
                    if(media >= 7 && faltas <= 10){
                        Console.WriteLine("seja bem vindo");
                    }
                    else{
                        Console.WriteLine("que pena, voce precisa melhorar sua media e faltas");
                    }
                }
                else{
                    Console.WriteLine("ok, passar bem!");
                }
        }
    }
}
