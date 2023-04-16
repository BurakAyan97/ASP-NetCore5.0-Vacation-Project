using SignalRForSql.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRForSql.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitorList",_visitorService.GetVisitorChartList());
        }
    }
}
