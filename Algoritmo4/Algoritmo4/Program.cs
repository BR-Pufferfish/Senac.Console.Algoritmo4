//Biblioteca do CultureInfo.InvariantCulture
using System.Globalization;
using System.Numerics;

//Variáveis
double largura, comprimento, area, valorMetro, valorTerreno;

//Entrada de dados.
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Calculo de dados.
area = largura * comprimento;
valorTerreno = area * valorMetro;

//Retorno visual.
Console.WriteLine("AREA - " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));