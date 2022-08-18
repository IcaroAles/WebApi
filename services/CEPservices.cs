using System.Net.Http;
using System.Net;

public class CEPService
{
private HttpClient client = null;

public CEPService(string service)
{
    client = new HttpClient();
    baseUrl = service; 
}

public CEP RequestCEP(string cep)
{
    var url = baseUrl.Replace("{cep}", cep);
    var response = await client.GetAsync(url);
    var content 
})
}