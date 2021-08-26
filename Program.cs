using FacadePattern.Subsistemas;
using System;

namespace FacadePattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Facade para consultar subsistemas para análise e concessão de crédito
            var concedeCreditoFacade = new Facade.Facade();
            var cliente = new Cliente("Jhonathan");
            var resultado = concedeCreditoFacade.PedirEmprestimo(cliente, 199000D);

            Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente.Nome} foi {(resultado ? "Aprovado" : "Negado")}!");
        }
    }
}
