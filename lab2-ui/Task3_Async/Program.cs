using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Downloading data...");
        string content = await DownloadAsync();

        string preview = content.Length > 100 ? content.Substring(0, 100) : content;
        Console.WriteLine("Downloaded content preview (first 100 chars): " + preview);
    }

    static async Task<string> DownloadAsync()
    {
        HttpClient client = new HttpClient();
        string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        return result;
    }
}