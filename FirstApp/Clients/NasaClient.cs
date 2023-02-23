using System.Net.Http.Json;
using FirstApp.Models;

namespace FirstApp.Clients;

public class NasaClient{
    
    private readonly HttpClient _client;

    public NasaClient(HttpClient client){
        _client = client;
    }

    public async Task<NasaResponse> GetNasa(){
        return await _client.GetFromJsonAsync<NasaResponse>("https://api.nasa.gov/planetary/apod?api_key=i0sBF5BKbCHv2qXHBmFdd4iXJChJjejXnVgbxvg8");

    }


}