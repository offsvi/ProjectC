//Crie um algoritmo que verifique se um número informado é par ou impar


int n = 0;
int r = 0;

//Pedindo para imprimir na tela
Console.WriteLine("Determina se o número é par ou impar");
Console.WriteLine("Informe um número: ");
n = Convert.ToInt32(Console.ReadLine()); //Utilizado para converter objetos
r = n % 2;
if (r == 1)//Determinando as condições Se
{
    Console.WriteLine("O número informado é impar");
}
else
{
    Console.WriteLine("O número informado é par");
}
Console.ReadLine();