using UniversalHardwareAssistant.Components.Models;

namespace UniversalHardwareAssistant.Components.Services;

public interface IPythonIntegrationService
{
    Task<DiagnosticsResult> GetDiagnosticsAnalysisAsync();
}