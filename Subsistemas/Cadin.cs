using System;

namespace FacadePattern.Subsistemas
{
    public class Cadin
    {
        public bool VerificarCadin(Cliente cliente)
        {
            Console.WriteLine($"Verificando o CADIN para o cliente {cliente.Nome}");

            return false;
        }
    }
}
