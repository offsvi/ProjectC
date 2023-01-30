/*
    Esse código faz a leitura de três nostas de um determinado aluno 
    e fornece para o professor(a) a média de três notas, sendo =7 ou maior 
    que 7 aprovado e inferior a sete reprovado.
    indicando se o aluno está em recuperção ou aprovado. 
*/

// Inicio do código 
class Conclusao 
{
    static void Main()
    {
        float media = 0;

        Console.WriteLine("Olá, Bem vindo ao programa de cálculo de média!");

        Console.WriteLine("Auxiliarei você a calcular a média do seu aluno!");

        Console.WriteLine("Digite a primeira nota: ");
        int.TryParse(Console.ReadLine(), out int nota1);

        Console.WriteLine("Digite a segunda nota: ");
        int.TryParse(Console.ReadLine(), out int nota2);

        Console.WriteLine("Digite a segunda nota: ");
        int.TryParse(Console.ReadLine(), out int nota3);

        media = (nota1 + nota2 + nota3) / 3;

        if(media < 7)
        {
            Console.WriteLine("A média do aluno é: {0}", media);
        }
        else
        {
            Console.WriteLine("Aluno Aprovado!");
        }
    }
}

// Fim do código