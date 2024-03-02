int x = 25; //Definindo valor de X
int y = x; //Copiando valor de X

Console.WriteLine(x);
Console.WriteLine(y);

x = 10; //Alterando o valor de X

Console.WriteLine(x);

var arr = new string[2];
arr[0] = "Item 1";

var arr2 = arr;

Console.WriteLine(arr);
Console.WriteLine(arr2);

arr[0] = "Item 2" //Ambos array utilizam a mesma referência de memória.


Console.WriteLine(arr);
Console.WriteLine(arr2);