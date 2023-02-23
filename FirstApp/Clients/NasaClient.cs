using System.Net.Http.Json;
using FirstApp.Models;

namespace FirstApp.Clients;

public class NasaClient{
    
    private readonly HttpClient _client;

    public NasaClient(HttpClient client){
        _client = client;
    }
    
    public string newdate {get; set;}

    public async Task<NasaResponse> GetNasa(){
        
        var url = "https://api.nasa.gov/planetary/apod?api_key=i0sBF5BKbCHv2qXHBmFdd4iXJChJjejXnVgbxvg8";
        
        return await _client.GetFromJsonAsync<NasaResponse>(url+"&date="+newdate);

    }


}