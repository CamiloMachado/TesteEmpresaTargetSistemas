//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

string? texto;
char[] caracter;

texto = "Texto usado caso não seja digitado nada.";

Console.WriteLine("\n\t---------- Inversor de texto ----------\n");

Console.Write("Informe o texto que deseja inverter: ");
texto = Convert.ToString(Console.ReadLine());

if (texto == "" || texto == " ")
{
    texto = "Texto usado caso não seja digitado nada.";
}

caracter = texto.ToCharArray();

Console.WriteLine("");

for (int i = texto.Length; i > 0; i--)
{
    Console.Write(caracter[i - 1]);
}
Console.WriteLine("");