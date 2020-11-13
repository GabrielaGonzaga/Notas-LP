using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código do programa
            // C# é uma linguagem case sensitive

            // Declarar as variaveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;

            // Entrada de dados
            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota");
            nota1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota");
            nota3 = float.Parse(Console.ReadLine());

            // Processamento
            media = (nota1+nota2+nota3)/3;

            // Exibir o resultado
            if(media>5){
                // Valor verdadeira
                Console.WriteLine("O aluno "+nomeCompleto+" está APROVADO com a média de :" +media);
            }
            else{
                // Valor falso
                Console.WriteLine("O aluno "+nomeCompleto+" está REPROVADO com a média de :" +media);
            }

             

        }
    }
}
