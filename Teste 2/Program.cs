//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número,
//ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

//IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente
//definido no código;

using System.ComponentModel.DataAnnotations;

int atual = 1, anterior = 0, soma = 0, num = 0;
char igual = 'n';

Console.WriteLine("Sequência de Fibonacci\n");

Console.Write("Informe um número: ");
num = Convert.ToInt32(Console.ReadLine());

// Validar se o número informado é igual à 0 ou 1
if ((num == anterior) || (num == atual))
{
    igual = 's';
}
else
{
    //Faz o calculo de somar o anterior com o atual.
    for (int i = 0; i < 30; i++)
    {
        soma = atual + anterior;

        anterior = atual;
        atual = soma;

        // Valida se o número informado foi igual algum valor da sequência de Fibonacci
        if (soma == num)
        {
            igual = 's';
        }
    }
}

// Valida se houve igualdade
if (igual == 's')
{
    Console.WriteLine("\nO número informado pertence a sequência de Fibonacci.");
}
else
{
    Console.WriteLine("\nO número informado não pertence a sequência de Fibonacci.");
}