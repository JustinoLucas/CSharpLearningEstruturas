Console.WriteLine("-- Instrução If --\n");

//Console.WriteLine("Cliente Especial (S/N)");
//var resposta = Console.ReadLine();

//if(resposta == "S")
//{
//    Console.WriteLine("Desconto de 10%");
//}

//Console.WriteLine("Cliente Especial (true/false)");
//var resposta = Convert.ToBoolean(Console.ReadLine());

//if (resposta)
//{
//    Console.WriteLine("Desconto de 10%");
//}

Console.WriteLine("Informe o valor de X: \t");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de Y: \t");
int y = Convert.ToInt32(Console.ReadLine());
if(x > y)
{
    Console.WriteLine("X é maior que Y");
}
if(y > x)
{
    Console.WriteLine("Y é maior que X");
}
if(x == y)
{
    Console.WriteLine("X é igual a Y");
}
Console.ReadKey(); 
