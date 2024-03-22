using System.Text;

var txtInterpolacao = "Testando " + " ";
var txtInterpolacao2 = $"Testando {txtInterpolacao}";
var txtInterpolacao3 = $"Testando {1 + 1}";
var txtInterpolacao4 = @"\Testando \\";

Console.WriteLine(txtInterpolacao);
Console.WriteLine(txtInterpolacao2);
Console.WriteLine(txtInterpolacao3);
Console.WriteLine(txtInterpolacao4);

var txtComparacao = "Testando";
Console.WriteLine(txtComparacao.CompareTo("Testando")); // Retorna 1 - Verdadeiro
Console.WriteLine(txtComparacao.CompareTo("testando")); // Retorna 0
Console.WriteLine(txtComparacao.CompareTo("")); // Retorna 0
Console.WriteLine(txtComparacao.CompareTo(null)); // Retorna 0

var txtContains = "Este é um texto de teste";
Console.WriteLine(txtContains.Contains("teste")); // true
Console.WriteLine(txtContains.Contains("Teste")); // false
Console.WriteLine(txtContains.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true
// Console.WriteLine(texto.Contains(null)); // ERRO

var txtComecaTermina = "Este é um texto de teste";
Console.WriteLine(txtComecaTermina.StartsWith("Este")); // true
Console.WriteLine(txtComecaTermina.StartsWith("este")); // false
Console.WriteLine(txtComecaTermina.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // true

Console.WriteLine(txtComecaTermina.EndsWith("Teste")); // false
Console.WriteLine(txtComecaTermina.EndsWith("teste")); // true
Console.WriteLine(txtComecaTermina.EndsWith("teste", StringComparison.OrdinalIgnoreCase)); // true

var txtIgualdade = "Este é um texto de teste";
Console.WriteLine(txtIgualdade.Equals("Este é um texto de teste")); // true
Console.WriteLine(txtIgualdade.Equals("este é um texto de teste")); // false
Console.WriteLine(txtIgualdade.Equals("este é um texto de teste", StringComparison.OrdinalIgnoreCase)); // true


var txtIndex = "Este é um texto de teste";
Console.WriteLine(txtIndex.IndexOf("é"));
Console.WriteLine(txtIndex.LastIndexOf("s"));

var txtMinMai = "Este é um texto de teste";
Console.WriteLine(txtMinMai.ToLower());
Console.WriteLine(txtMinMai.ToUpper());

var txtInsert = "Este é um texto de teste";
Console.WriteLine(txtInsert.Insert(5, "AQUI "));

var txtTamanho = "Este é um texto de teste";
Console.WriteLine(txtTamanho.Length);

var txtRemover = "Este é um texto de teste";
Console.WriteLine(txtRemover.Remove(0, 5));

var txtSubstituir = "Este é um texto de teste";
Console.WriteLine(txtSubstituir.Replace("Este", "Isto"));
Console.WriteLine(txtSubstituir.Replace("texto", "exemplo"));

var txtSplit = "Este é um texto, de teste";
var divisao = txtSplit.Split(',');
Console.WriteLine(divisao[0]);
Console.WriteLine(divisao[1]);
// Console.WriteLine(divisao[2]); // ERRO

var txtUltima = "Este é um texto de teste";
Console.WriteLine(txtUltima.Substring(0, 5));
Console.WriteLine(txtUltima.Substring(txtUltima.LastIndexOf(" ") + 1, 5));



var txtSemEspacos = "Este é           um texto de teste";
Console.WriteLine(txtSemEspacos.Trim());

txtSemEspacos = "       Este é um texto de teste             ";
Console.WriteLine(txtSemEspacos.Trim());

var txtBuilder = new StringBuilder();
txtBuilder.Append("Este");
txtBuilder.Append("é");
txtBuilder.Append("um");
txtBuilder.Append(Environment.NewLine);
txtBuilder.Append("texto");
Console.WriteLine(txtBuilder.ToString());
