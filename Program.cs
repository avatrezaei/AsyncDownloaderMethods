using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            string url = "https://example.com";

            Console.WriteLine("Running DownloadStringAsync...");
            var downloadAsyncResult = await DownloadStringAsync(url);
            Console.WriteLine("DownloadStringAsync Result: " + downloadAsyncResult);

            Console.WriteLine("\nRunning DownloadStringWithContinueWith...");
            var downloadContinueWithResult = DownloadStringWithContinueWith(url);
            Console.WriteLine("DownloadStringWithContinueWith Result: " + downloadContinueWithResult);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    public static async Task<string> DownloadStringAsync(string url)
    {
        using (var httpClient = new HttpClient())
        {
            try
            {
                string result = await httpClient.GetStringAsync(url);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public static Task<string> DownloadStringWithContinueWith(string url)
    {
        var httpClient = new HttpClient();
        Task<string> downloadLink = httpClient.GetStringAsync(url);
        return downloadLink.ContinueWith(downloadAntecedent =>
        {
            try
            {
                return downloadAntecedent.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        });
    }


}

