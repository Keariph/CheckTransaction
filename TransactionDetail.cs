using System.Text.Json.Serialization;
using TronScan.API.Classes;

namespace CheckTransaction
{
    public class TransactionDetail
    {
        [JsonPropertyName("contract_map")]
        public Dictionary<string, bool> ContractMap { get; set; } = new();

        [JsonPropertyName("contractRet")]
        public string ContractRet { get; set; } = "";

        [JsonPropertyName("cost")]
        public TransactionCost Cost { get; set; } = new();

        [JsonPropertyName("data")]
        public string Data { get; set; } = "";

        [JsonPropertyName("contractInfo")]
        public Dictionary<string, object> ContractInfo { get; set; } = new();

        [JsonPropertyName("contractType")]
        public int ContractType { get; set; } = 0;

        [JsonPropertyName("addressTag")]
        public Dictionary<string, object> AddressTag { get; set; } = new();

        [JsonPropertyName("revert")]
        public bool Revert { get; set; } = false;

        [JsonPropertyName("confirmations")]
        public int Confirmations { get; set; } = 0;

        [JsonPropertyName("toAddress")]
        public string ToAddress { get; set; } = "";

        [JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; } = false;

        [JsonPropertyName("trigger_info")]
        public Dictionary<string, object> TriggerInfo { get; set; } = new();

        [JsonPropertyName("block")]
        public int Block { get; set; } = 0;

        [JsonPropertyName("signature_addresses")]
        public List<object> SignatureAddresses { get; set; } = new();

        [JsonPropertyName("ownerAddress")]
        public string OwnerAddress { get; set; } = "";

        [JsonPropertyName("srConfirmList")]
        public List<SrConfirmList> SrConfirmList { get; set; } = new();

        [JsonPropertyName("riskTransaction")]
        public bool RiskTransaction { get; set; } = false;

        [JsonPropertyName("hash")]
        public string Hash { get; set; } = "";

        [JsonPropertyName("contractData")]
        public ContractData ContractData { get; set; } = new();

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; } = 0;

        [JsonPropertyName("internal_transactions")]
        public Dictionary<string, object> InternalTransactions { get; set; } = new();

        [JsonPropertyName("info")]
        public Dictionary<string, object> Info { get; set; } = new();

        [JsonPropertyName("normalAddressInfo")]
        public Dictionary<string, NormalAddressInfo> NormalAddressInfo { get; set; } = new();
    }
}
