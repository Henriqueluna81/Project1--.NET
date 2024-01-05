using System.Diagnostics.Contracts;
using Project1__.NET.Models;

PessoaFisica P = new PessoaFisica();

P.Nome = "Henrique";
P.Idade = 17;
P.Apreseentar();

if(P.Idade >= 18){

 Console.WriteLine("Sou maior de idade.");

} else{

    Console.WriteLine("Sou menor de idade.");

}

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
    break;

        default:
            Console.WriteLine("Não é vogal.");
        break;        
}

Calculadora C = new Calculadora();
C.RaizQuadrada(9);


//TABUADA DO 5 USANDO FOR
Console.WriteLine("");
Console.WriteLine("Tabuada do 5: ");

int numero = 5; 

for(int contador = 1; contador <= 10; contador ++){
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
}

//TAABUADA DO 6 USANDO WHILE
Console.WriteLine("");
Console.WriteLine("Tabuada do 6: ");

int numerozinho = 6; 
int contadorzinho = 0; 

while(contadorzinho <= 10){
    Console.WriteLine($"{numerozinho} X {contadorzinho} = {numerozinho * contadorzinho}");
    contadorzinho ++; 
}

//TABUADA DO 7 USANDO WHILE COM IF
Console.WriteLine("");
Console.WriteLine("Tabuada do 6: ");

int numeral = 7; 
int contadores = 0; 

while(contadores <= 10){
    Console.WriteLine($"{numeral} X {contadores} = {numeral * contadores}");
    contadores ++; 

    if(contadores == 6){
        break;
    }
}


//SOMANDO NUMEROS COM DO WHILE
int soma = 0, novonumero = 0; 

do{

    Console.WriteLine("Digite um numero (0 para parar): ");
    novonumero = Convert.ToInt32(Console.ReadLine());
    soma += novonumero; 

}while(novonumero != 0);

Console.WriteLine($"A soma total dos numeros é: {soma}");


