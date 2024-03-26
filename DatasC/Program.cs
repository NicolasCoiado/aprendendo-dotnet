using System.Globalization;

var aniversario = new DateTime(2003, 12, 03, 14, 30, 10);
var dataHoje = DateTime.Now;
var formatada = String.Format("{0:r}", dataHoje);

if (dataHoje == aniversario)
{
    Console.WriteLine("Nasceuu");
}
else
{
    Console.WriteLine("Já nasceu faz tempo :(");
}

Console.WriteLine(aniversario);
Console.WriteLine(formatada);
Console.WriteLine(dataHoje.AddDays(12));

var en = new CultureInfo("en-UK");
var utcDate = DateTime.UtcNow;
Console.WriteLine(DateTime.Now.ToString("D", en));
Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime());

var timeSpan = new TimeSpan(1);
Console.WriteLine(timeSpan);