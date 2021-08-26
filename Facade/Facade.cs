using FacadePattern.Subsistemas;
using System;

namespace FacadePattern.Facade
{
    public class Facade
    {
        private readonly Cadastro cadastro;
        private readonly Serasa serasa;
        private readonly Cadin cadin;
        private readonly LimiteCredito limiteCredito;

        public Facade()
        {
            this.cadastro = new Cadastro();
            this.serasa = new Serasa();
            this.cadin = new Cadin();
            this.limiteCredito = new LimiteCredito();
        }

        public bool PedirEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"Checando possibilidade de empréstimo para o cliente {cliente.Nome} no valor de {valor:C}\n");

            bool emprestimoConcedido = true;
            cadastro.CadastrarCliente(cliente);

            // Serasa
            if (serasa.VerificarSerasa(cliente))
            {
                Console.WriteLine($"Cliente {cliente.Nome} possui restrição no SERASA");
                emprestimoConcedido = false;
            }
            // Cadin
            else if (cadin.VerificarCadin(cliente))
            {
                Console.WriteLine($"Cliente {cliente.Nome } possui restrição no CADIN");
                emprestimoConcedido = false;
            }

            // Limite de crédito para o valor
            else if (!limiteCredito.VerificarLimiteCredito(cliente, valor))
            {
                Console.WriteLine($"O Cliente {cliente.Nome} possui limite de crédido inferior a {valor:C}");
                emprestimoConcedido = false;
            }

            return emprestimoConcedido;
        }
    }
}
