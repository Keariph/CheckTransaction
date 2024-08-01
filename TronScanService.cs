using System.Text.Json;

namespace CheckTransaction
{
    public class TronScanService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://apilist.tronscan.org/api/";

        public TronScanService(HttpClient httpClient, string? tronScanApiKey = null)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "TronScan.API Blazor Client");
            _httpClient.DefaultRequestHeaders.Add("TRON-PRO-API-KEY", tronScanApiKey ?? "");
        }

        /// <summary>
        /// Base method for GET requests.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<Stream> GetRequestAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStreamAsync();
        }

        /// <summary>
        /// Return transaction detail. 
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public async Task<TransactionDetail?> GetTransactionDetailAsync(string hash)
        {
            try
            {
                var stream = await GetRequestAsync($"transaction-info?hash={hash}");
                return await JsonSerializer.DeserializeAsync<TransactionDetail>(stream);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
