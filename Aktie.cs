using System.Net;
using System.Text.Json.Nodes;

namespace WinFormsApp1
{
    internal class Aktie
    {
        //Propeties
        internal string symbol;
        internal DateOnly lastRefresh;
        internal SortedDictionary<DateOnly, decimal> data;

        protected const string apiKey = "NJPOK4EDP0VJFKQM";
        protected const string apiUrl = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={0}&outputsize=compact&apikey={1}";

        //Constructors
        internal Aktie(string newSymbol)
        {
            data = new SortedDictionary<DateOnly, decimal>();
            lastRefresh = DateOnly.MinValue;
            symbol = newSymbol;
            this.CallApi();
        }

        //Methods
        protected void CallApi()
        {

            try
            {

                using (WebClient client = new WebClient())

                {
                    string jsonData = client.DownloadString(string.Format(apiUrl, symbol, apiKey));
                    JsonNode document = JsonNode.Parse(jsonData);
                    if (symbol != document["Meta Data"]["2. Symbol"].GetValue<string>())
                        return;
                    lastRefresh = DateOnly.Parse(document["Meta Data"]["3. Last Refreshed"].GetValue<string>());
                    foreach (KeyValuePair<string, JsonNode?> jsonPair in document["Time Series (Daily)"] as JsonObject)
                    {
                        data.Add(DateOnly.Parse(jsonPair.Key), decimal.Parse(jsonPair.Value["4. close"].GetValue<string>()));
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}



