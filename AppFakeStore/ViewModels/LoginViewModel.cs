using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


public class LoginViewModel
{
    private readonly HttpClient _httpClient; //para enviar solicitudes HTTP

    public LoginViewModel()
    {
        _httpClient = new HttpClient();//Ctor para enviar datos a la api
    }

    // Método para realizar el Login
    public async Task<bool> Login(string username, string password)
    {

        var loginUrl = "https://fakestoreapi.com/auth/login"; 

        var loginData = new
        {
            username = username,
            password = password
        };

        try
        {
            var response = await _httpClient.PostAsJsonAsync(loginUrl, loginData); //METODO POST utilizando HttpClient en .NET para enviar datos en formato JSON a un endpoint.

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();// lee la respuesta como una cadena de texto

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
       
    }
}
