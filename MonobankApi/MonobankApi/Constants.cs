namespace MonobankApi
{
    internal class Constants
    {
        public static string Base_Url = "https://api.monobank.ua";
        public static string X_Token = "X-Token";
        public static class Routes
        {
            public static string Client_Info = "personal/client-info";
            public static string Currency_Rate = "bank/currency";
            public static string Transactions = "personal/statement/{0}/{1}/{2}";
        }
    }
}