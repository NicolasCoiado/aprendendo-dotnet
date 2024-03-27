using System.Globalization;

decimal valor = 18536.25m;

var culture = CultureInfo.CreateSpecificCulture("en-US");
Console.WriteLine(valor.ToString(culture));

Console.WriteLine(Math.Round(valor));
Console.WriteLine(Math.Ceiling(valor)); //Arredonda para cima
Console.WriteLine(Math.Floor(valor)); //Arredonda para baixo