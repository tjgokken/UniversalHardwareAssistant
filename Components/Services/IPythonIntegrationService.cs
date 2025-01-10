using HAL.Components.Models;

namespace HAL.Components.Services;

public interface IPythonIntegrationService
{
    Task<DiagnosticsResult> GetDiagnosticsAnalysisAsync();
}