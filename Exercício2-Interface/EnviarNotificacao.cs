using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2_Interface
{
    public class EnviarNotificacaoWhatsapp : IEnviarNotificação
    {
        public void EnviarMensagemCliente()
        {
            Console.WriteLine("Estou enviando uma mensagem no Whatsapp do Cliente");
        }

    }
}
