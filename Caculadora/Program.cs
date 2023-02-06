using Caculadora;

Console.WriteLine("Bem-vindo a Caluladora!");
Operacoes operacoes = new Operacoes();
Console.WriteLine();
Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(1, 2));
Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(3, 4));
Console.WriteLine("O valor é: " + operacoes.Multipicacao.Calcular(6, 5));
Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(8, 2));