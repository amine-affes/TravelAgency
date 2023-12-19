using Newtonsoft.Json;
using System.Net.Http.Headers;
using Travel_Agency_Project.Entities.Clients;
using Travel_Agency_Project.Entities.Dossiers;

namespace Travel_Agency_Project.Services.Clients
{
    public class ClientService : IClientService
    {
        public async Task<Dossier?> GetClient(string name, string familyName)
        {
            try
            {
                using (HttpClient clienthttp = new HttpClient())
                {
                    clienthttp.BaseAddress = new Uri("https://localhost:7165/GraphQL?name=" + name + "&familyName=" + familyName);
                    clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = clienthttp.GetAsync("").Result;
                    var result = JsonConvert.DeserializeObject<Dossier>(await response.Content.ReadAsStringAsync());
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
