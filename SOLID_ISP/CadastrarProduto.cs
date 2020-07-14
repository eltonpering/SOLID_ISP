using System;

namespace SOLID_ISP
{
    class CadastrarProduto : IPersistencia
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Valida Dados Produto");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar Dados Cliente");
        }
    }
}
