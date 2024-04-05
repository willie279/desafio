// See https://aka.ms/new-console-template for more information
// realizacion de desafio para combinar valores de matriz como cadenas y como enteros
string[] value4 = { "11", "12.4", "ABC", "34", "DEF" };
decimal sum4 = 0m;
string message1 = "";
foreach (string count in value4)
{
    if (decimal.TryParse(count, out decimal total))
    {

        sum4 += total;
    }
    else
    {
        message1 += count;
    }
}
Console.WriteLine($"total: {sum4}");
Console.WriteLine($"messsage: {message1}");

// desafio para generar operaciones matematicas como tipo de numero especifico
int first = 12;
decimal value5 = 6.2m;
float value6 = 4.3f;

int result = first / Convert.ToInt32(value5);
int result1 = Convert.ToInt32(first / value5); // otra forma de hacerlo
decimal result2 = value5 / Convert.ToDecimal(value6);
decimal result3 = value5 / (decimal)value6; // otra forma de hacerlo
float result4 = value6 / first;// otra forma de hacerlo
float result5 = value6 / (float)first;
Console.WriteLine($"divide first by value5, display the result as an int; {result}");
Console.WriteLine($"divide first by value5, display the result as an int; {result1}");
Console.WriteLine($"divide value5 by value6, display the result as an decimal; {result2}");
Console.WriteLine($"divide value5 by value6, display the result as an decimal; {result3}");
Console.WriteLine($"divide value6 by first, display the result as an decimal; {result4}");
Console.WriteLine($"divide value6 by first, display the result as an decimal; {result5}");
