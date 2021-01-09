using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkWithURL
{
    class Program
    {
        static async Task Main()
        {
            HttpClient getHTTPclient = new HttpClient();
            HttpResponseMessage responseMessage = await getHTTPclient.GetAsync("https://en.wikipedia.org/wiki/Contact_list");
            HttpContent content = responseMessage.Content;
            string httpContent = await content.ReadAsStringAsync();

            Console.WriteLine(httpContent);

            const string emailPattern = @"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}";
            const string linkPattern = @"https://[a-zA-Z.:/_]+";
            const string phonePattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

            var regexEmail = new Regex(emailPattern);
            var regexLink = new Regex(linkPattern);
            var regexPhone = new Regex(phonePattern);

            StreamWriter writer = File.CreateText("Test.txt");

            foreach (Match match in regexEmail.Matches(httpContent))
            {
                writer.WriteLine($"E-mail: {match.Value}");
            }

            foreach (Match match in regexLink.Matches(httpContent))
            {
                writer.WriteLine($"Link: {match.Value}");
            }

            foreach (Match match in regexPhone.Matches(httpContent))
            {
                writer.WriteLine($"Phone: {match.Value}");
            }

            writer.Close();

            Console.ReadKey();
        }
    }
}
