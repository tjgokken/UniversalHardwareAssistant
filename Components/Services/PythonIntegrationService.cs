using HAL.Components.Models;

namespace HAL.Components.Services;

public class PythonIntegrationService : IPythonIntegrationService
{
    private readonly string _apiUrl;
    private readonly HttpClient _httpClient;

    public PythonIntegrationService(IConfiguration configuration)
    {
        _httpClient = new HttpClient();
        _apiUrl = "http://localhost:5000/recommendations";
    }

    public async Task<DiagnosticsResult> GetDiagnosticsAnalysisAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<DiagnosticsResult>();
            return result ?? new DiagnosticsResult { Status = "error", ErrorMessage = "Failed to parse response" };
        }
        catch (Exception ex)
        {
            return new DiagnosticsResult
            {
                Status = "error",
                ErrorMessage = $"Failed to get diagnostics analysis: {ex.Message}"
            };
        }
    }
}