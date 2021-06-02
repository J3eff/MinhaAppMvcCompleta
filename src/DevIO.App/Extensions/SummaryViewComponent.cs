using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevIO.App.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Por esta dentro de um contexto assíncrono preciso receber ele desta forma, para possibilitar compatibilidade
            var notificacoes = await Task.FromResult(_notificador.ObterNotificaoes());

            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));

            return View();
        }
    }
}
