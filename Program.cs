using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace CheckTransaction
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string hash = "853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2";
            var configuration = new ConfigurationBuilder()
               .AddUserSecrets(Assembly.GetExecutingAssembly())
               .Build();
            string connectionString = configuration.GetConnectionString("TronScanKey");
            HttpClient client = new HttpClient();
            TronScanService service = new TronScanService(client, connectionString);
            TransactionDetail detail = await service.GetTransactionDetailAsync(hash);
            Console.WriteLine("riskTransaction: " + detail.RiskTransaction);
        }
    }
}

