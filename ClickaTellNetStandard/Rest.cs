using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Clickatell_Service
{
    class Rest
    {
        //This takes the API Key and JSON array of data and posts it to the Message URL to send the SMS's
        public static async Task<string> Post(string Token, string json)
        {
            var httpClient = new HttpClient();
            var stringContent = new StringContent(json,Encoding.UTF8,"application/json");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
            var response=await httpClient.PostAsync("https://platform.clickatell.com/messages", stringContent);           

         
            using (var streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }
    }
}
