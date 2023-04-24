

// operador "E" ou and precisa que ambas as expressões sejam verdadeira para retornar
// verdadeiro
bool c1 = 2 > 3 && 4 != 5; // false

// o operador "OU" no caso "OR" precisa que somente uma das expressões sejam verdadeira para
// retornar verdadeiro
bool c2 = 2 > 3 || 4 != 5; // true

// aqui utilizamos o operador "Não" ou "NOT" ele vai negar ou inverter o valor da variavel
bool c3 = !(2 > 3) || 4 != 5; // true

// esses operadores são muito utilizados para validações de dados e controle de fluxo do
// programa portanto são uma ferramenta indispensável para todo programador.

System.Console.WriteLine($"c1 {c1}");
System.Console.WriteLine($"c2 {c2}");
System.Console.WriteLine($"c3 {c3}");