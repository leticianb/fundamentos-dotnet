using fundamentos_dotnet.Models;

int[] arraysInteiros = new int[3];
arraysInteiros[0]= 72;
arraysInteiros[1]= 73;
arraysInteiros[2]= 74;


for(int contador=0; contador<arraysInteiros.Lenght; contador++){
    Console.WriteLine(arraysInteiros[contador]);
    
}




// Calculadora calc = new Calculadora();
// calc.Somar(3,6);
// calc.Subtrair(3,6);
// calc.Multiplicar(3,6);
// calc.Dividir(3,6);
// calc.Potencia(2,3);
// calc.Raiz(3);
// string numero = Console.ReadLine();
// int number = int.Parse(numero);
// for (int contador = 1; contador<=10; contador++){
//     int result = number*contador;
//     Console.WriteLine(result);

// }
// int cont =1;
// while(cont<=10){
//     int result = number*cont;
//     Console.WriteLine(result);
//     cont++;
// }
// int soma = 0, num = 0;

// do {
//     Console.WriteLine("digite um numero");
//     num = Convert.ToInt32(Console.ReadLine());
//     soma +=num;


// }while(num!=0);
// Console.WriteLine(soma);

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();
// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;
//     default:
//         Console.WriteLine("Não vogal");
//         break;

// }
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// Console.WriteLine($"Quantidade em esqtoque: {quantidadeEmEstoque}");

// if(quantidadeCompra ==0){
//     Console.WriteLine("Compra inválida");
// }

// else if(quantidadeEmEstoque>= quantidadeCompra){
//     Console.WriteLine("Venda realizada");
//     quantidadeEmEstoque--;
//     Console.WriteLine(quantidadeEmEstoque);
// }
// else{
//     Console.WriteLine("Não foi possível efetuar a compra");
// }


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



