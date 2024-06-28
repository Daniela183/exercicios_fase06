﻿//aula 147
using Exercicio01;

Console.WriteLine("Exercício 01\n");
Console.WriteLine("Crie um programa que implemente uma interface IVeiculo com dois métodos, um para Dirigir do tipo void e outro para Abastecer do " +
    "tipo bool que possui um parâmetro do tipo int com a quantidade de gasolina a abastecer.(defina isso como uma propriedade) " +
    "Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a quantidade inicial de gasolina do carro e implemente os " +
    "métodos Dirigir e Abastecer do carro.O método Dirigir deve exibir na tela ”Dirigindo o carro..”, se a gasolina for maior que 0, caso " +
    "contrário deve exibir “Sem gasolina...”, e o método Abastecer deve aumentar a gasolina do carro e retornar true.Para testar, crie um " +
    "objeto do tipo Carro com 0 de gasolina inicial e solicite ao usuário a informação de uma quantidade de gasolina para abastecer via teclado " +
    "e por fim execute o método Dirigir do carro.\n");


Carro carro = new Carro(0);
Console.Write("Informe quantos litros de gasolina: ");
int gasolina = Convert.ToInt32(Console.ReadLine());
if (carro.Abastecer(gasolina))
{
carro.Dirigir();
}
Console.ReadKey();
class Carro : IVeiculo
{
    public int Gasolina { get; set; }
    public Carro(int gasolina)
    {
        Gasolina = gasolina;
    }
    public void Dirigir()
    {
        if (Gasolina > 0)
        {
            Console.WriteLine("\nDirigindo o carro...");
        }
        else
        {
            Console.WriteLine("\nSem gasolina...");
        }
    }
    public bool Abastecer(int quantidade)
    {
        Gasolina += quantidade;
        return true;
    }
}
