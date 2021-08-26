using System;

namespace FacadePattern.Subsistemas
{
    public class Serasa
    {
        public bool VerificarSerasa(Cliente cliente)
        {
            Console.WriteLine($"Verificando SERASA do cliente {cliente.Nome}");

            return false;
        }
    }
}
