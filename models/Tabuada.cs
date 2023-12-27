using System;

 Console.WriteLine($"\nConhecendo as estruturas de repetiçoes em C#.\n");

/*
int numero = 10;

Console.WriteLine($"{numero} x 1 = {numero * 1}");

 //-----------------------------------------------------------------------------

  for 1 contador 

int numero = 9;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
}

//-------------------------------------------------------------------------------



int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{contador + 1}° Execução:{numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 9)
    {
        break;
    }
}

//------------------------------------------------------------------------------------


int soma = 0,numero = 0;

do 
{
    Console.WriteLine("Digite um valor ou numero para somar e o (0 para parar.");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero  != 0);

Console.WriteLine($"total da soma dos números digitados é {soma}");


//-------------------------------------------------------------------------------------
*/

string opçao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua Opção;");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opçao = Console.ReadLine();

    switch(opçao)
    {
        case "1":
           Console.WriteLine("Cadastro de Cliente");
           break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            // Environment.Exit(0);
            break;

        default:
             Console.WriteLine("Opção  Invalida.");
             break;    

    }
}







/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para ver a tabuada:");
        
        // Lê o número inserido pelo usuário
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Imprime a tabuada do número inserido
            ImprimirTabuada(numero);
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    static void ImprimirTabuada(int numero)
    {
        Console.WriteLine($"Tabuada do {numero}:");

        // Loop para calcular e imprimir a tabuada
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
*/