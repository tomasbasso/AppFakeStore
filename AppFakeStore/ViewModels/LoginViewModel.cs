using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


public class LoginViewModel
{
    private readonly HttpClient _httpClient;

    public LoginViewModel()
    {
        _httpClient = new HttpClient();
    }

    // Método para realizar el Login
    public async Task<bool> Login(string username, string password)
    {
        var loginUrl = "https://fakestoreapi.com/auth/login"; // Fake Store API no tiene este endpoint, pero puedes simularlo o usar uno real si tienes.

        var loginData = new
        {
            username = username,
            password = password
        };

        try
        {
            var response = await _httpClient.PostAsJsonAsync(loginUrl, loginData);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                // Aquí puedes manejar el token o la respuesta
                return true;
            }
            else
            {
                // Manejar error de autenticación
                return false;
            }
        }
        catch (Exception ex)
        {
            // Manejo de errores, por ejemplo, conexión fallida
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}
