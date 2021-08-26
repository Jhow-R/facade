using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsistemas
{
    public class LimiteCredito
    {
        public bool VerificarLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine($"Verificando o limite de crédito do cliente {cliente.Nome}");

            if (valor > 200000D)
                return false;

            return true;
        }
    }
}
