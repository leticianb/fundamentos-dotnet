using fundamentos_dotnet.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
Console.WriteLine($"Quantidade em esqtoque: {quantidadeEmEstoque}");

if(quantidadeEmEstoque>= quantidadeCompra){
    Console.WriteLine("Venda realizada");
    quantidadeEmEstoque--;
    Console.WriteLine(quantidadeEmEstoque);
}
else{
    Console.WriteLine("Não foi possível efetuar a compra");
}


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/mm/yyyy HH:mm"));

// int a = Convert.ToInt32("5");
// int a = int.Parse("5"); outra forma
// Console.WriteLine(a);
// int b = 6;
// string c = b.ToString();



// string apresentacao = "olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.84;
// decimal preco = 1.80M;
// bool condicao = true;
// Console.WriteLine(apresentacao);
// Console.WriteLine("Quantidade de alunos: " + quantidade);
// Console.WriteLine("Altura do aluno: " + altura.ToString("0.000"));
// Console.WriteLine("Valor da variavel preço: " + preco);
// Console.WriteLine("Valor da variavel condição: " + condicao);



// fundamentos_dotnet.Models.Pessoa p = new fundamentos_dotnet.Models.Pessoa();
// Pessoa p = new Pessoa();

// p.Nome = "Leticia";
// p.Idade = 19;
// p.Apresentar();



