using DevIO.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao(); // Valida se tem notificação 
        List<Notificacao> ObterNotificaoes(); // Retorna uma lista de notificação
        void Handle(Notificacao notificacao); // Manipula lista de notificação quando ela for lançada

    }
}
