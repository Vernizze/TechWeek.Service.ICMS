using System.Threading;

namespace TechWeek.Service.ICMS
{
    class Program
    {
        static void Main(string[] args)
        {
            new Startup().Configure();

            Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }
}
