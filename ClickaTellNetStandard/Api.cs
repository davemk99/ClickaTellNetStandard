using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clickatell_Service
{
    public class Api
    {
        //This function is in charge of converting the data into a json array and sending it to the rest sending controller.
        public static async Task<string> SendSMS(string Token, Dictionary<string, string> Params)
        {
            Params["to"] = CreateRecipientList(Params["to"]);
            string JsonArray = JsonConvert.SerializeObject(Params, Formatting.None);
            JsonArray = JsonArray.Replace("\\\"", "\"").Replace("\"[", "[").Replace("]\"", "]");
            return await Rest.Post(Token, JsonArray);
        }

        //This function converts the recipients list into an array string so it can be parsed correctly by the json array.
        public static string CreateRecipientList(string to)
        {
            string[] tmp = to.Split(',');
            to = "[\"";
            to = to + string.Join("\",\"", tmp);
            to = to + "\"]";
            return to;
        }
        
    }
}
