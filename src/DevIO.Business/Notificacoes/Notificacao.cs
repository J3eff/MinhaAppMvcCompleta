using System;
using System.Linq;
using System.Text;

namespace DevIO.Business.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string menssagem)
        {
            Mensagem = menssagem;
        }

        public string Mensagem { get; }
    }
}
