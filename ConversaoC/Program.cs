float decima = 25.8F;
int inteiro = 25;

decima = inteiro; //Conversão implícita
uint inteiroSemSinal = (uint)inteiro; //Conversão explícita
int cem = int.Parse("100"); //Convertendo de String para int
int nove = Convert.ToInt32("9"); //Utilizando a classe Convert para converter

Console.WriteLine(inteiroSemSinal);
Console.WriteLine(cem);
Console.WriteLine(nove);
