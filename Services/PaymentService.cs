using picpay_desafio.Interface;

namespace picpay_desafio.Services;

public class PaymentService : IPaymentService
{
    private readonly string _apiUrl;
    private readonly HttpClient _httpClient;
    public PaymentService(HttpClient httpClient, IConfiguration config)
    {

        _httpClient = httpClient;
        _apiUrl = config.GetValue<string>("ApiSettings:ApiUrl") ?? throw new Exception ("Url do serviço de pagamento naõ encontrado!");
    }
    public async Task<bool> Validate()
    {
        try
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            return true; // response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro no serviço de verificação de pagamento!", ex);
        }
    }
}
