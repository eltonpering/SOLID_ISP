using System;

namespace SOLID_ISP
{
    class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar Email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar Dados Cliente");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar Dados Cliente");
        }
    }
}
