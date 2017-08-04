using TechWeek.Infra.CrossbarIo.Connection;
using TechWeek.Infra.CrossbarIo.RPC.Callee;
using TechWeek.Infra.CrossbarIo.Utils.Requests.RPC;
using TechWeek.Service.ICMS.Domain;
using TechWeek.Service.ICMS.DTOs;

namespace TechWeek.Service.ICMS
{
    public class Startup
    {
        private CrossbarConnection _conn;

        public Startup()
        {
            this._conn = new CrossbarConnection();

            this._conn.Initilize(new ConnectionParameters
            {
                ServerAddress = "192.168.1.6",
                Port = 8081,
                ServerRealm = "im_soft"
            });

            var con = this._conn.Connect();

            var res = con.Result;
        }

        public void Configure()
        {
            var calleeICMS = new Callee(this._conn);
            
            var res = calleeICMS.Run(new CalleeRequest<CalculoICMSRetorno, CalculoICMSParametro>
            {
                NomeMetodo = "br.com.techweek.service.icms.calc",
                Run = new Calcular().Run
            });
        }
    }
}
