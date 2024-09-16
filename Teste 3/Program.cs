//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar,
//que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

//IMPORTANTE:
//a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
//b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

using Newtonsoft.Json;
using Teste_3;

Console.WriteLine("\n\t--------- Faturamento ---------\n");

// Caminho para o arquivo JSON local
string caminhoArquivo = "D:\\Minhas coisas\\Camilo\\Teste TargetSistemas\\Teste\\Teste 3\\dados.json";

// Ler e desserializar o arquivo JSON
List<Faturamento> faturamentos = LerFaturamentos(caminhoArquivo);

if (faturamentos.Count == 0)
{
    Console.WriteLine("Nenhum dado de faturamento encontrado.");
    return;
}

// Calcular menor e maior valor de faturamento
decimal menorFaturamento = decimal.MaxValue;
decimal maiorFaturamento = decimal.MinValue;
decimal somaFaturamentos = 0;
int diasComFaturamento = 0;

foreach (var item in faturamentos)
{
    if (item.Valor < menorFaturamento)
        menorFaturamento = item.Valor;

    if (item.Valor > maiorFaturamento)
        maiorFaturamento = item.Valor;

    somaFaturamentos += item.Valor;
    diasComFaturamento++;
}

// Calcular a média mensal
decimal mediaMensal = diasComFaturamento > 0 ? somaFaturamentos / diasComFaturamento : 0;

// Contar os dias com faturamento superior à média
int diasAcimaDaMedia = 0;
foreach (var item in faturamentos)
{
    if (item.Valor > mediaMensal)
        diasAcimaDaMedia++;
}

// Exibir resultados
Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");

static List<Faturamento> LerFaturamentos(string caminhoArquivo)
{
    string json = File.ReadAllText(caminhoArquivo);
    return JsonConvert.DeserializeObject<List<Faturamento>>(json);
}