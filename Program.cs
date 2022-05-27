double C = 0;
double F = 0;
string nome = "";


Console.WriteLine("Olá qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome} quantos gráus fahrenheit quer converter?" );
F = Convert.ToDouble(Console.ReadLine());

C = (F -32) * 5 / 9;

Console.WriteLine($"{nome}, {F} gráus fahrenheit valem {C}  gráus célcius");

