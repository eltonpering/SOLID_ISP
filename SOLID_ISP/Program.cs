using System;

namespace SOLID_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new CadastrarProduto();
            produto.ValidarDados();
            produto.SalvarDataBase();

            var cliente = new CadastrarCliente();
            cliente.ValidarDados();
            cliente.SalvarDataBase();

            Console.ReadLine();
        }
    }
}
