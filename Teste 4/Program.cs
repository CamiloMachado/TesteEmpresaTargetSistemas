//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve
//dentro do valor total mensal da distribuidora.  

double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, outros = 19849.53, total = 0;

total = SP + RJ + MG + ES + outros;

Console.WriteLine("\n\t--------- Percentual de faturamento ---------\n");

Console.WriteLine("Percentual de representação que cada estado, teve dentro do valor total mensal da distribuidora:");
Console.WriteLine();

// Exibe os valores
Console.WriteLine($"SP - {CalculoPorcentagem(SP)}%");
Console.WriteLine($"RJ - {CalculoPorcentagem(RJ)}%");
Console.WriteLine($"MG - {CalculoPorcentagem(MG)}%");
Console.WriteLine($"ES - {CalculoPorcentagem(ES)}%");
Console.WriteLine($"Outros - {CalculoPorcentagem(outros)}%");

// Faz o calculo da porcentagem de cada estado e retorna uma string com valor arredondado.
string CalculoPorcentagem(double valor)
{
    double calculo = (((total + valor) - total) / total * 100);

    return calculo.ToString("N2");
};