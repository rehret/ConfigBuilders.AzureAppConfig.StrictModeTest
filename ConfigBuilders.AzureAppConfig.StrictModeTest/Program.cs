namespace ConfigBuilders.AzureAppConfig.StrictModeTest
{
    using System;
    using System.Configuration;

    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine($"TestKey (Env): '{ConfigurationManager.AppSettings["TestKey:Env"]}'");
            Console.WriteLine($"TestKey (AAC): '{ConfigurationManager.AppSettings["TestKey:AAC"]}'");
        }
    }
}