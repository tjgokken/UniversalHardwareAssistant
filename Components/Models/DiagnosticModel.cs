using System.Text.Json.Serialization;

namespace UniversalHardwareAssistant.Components.Models;

public class DiagnosticsResult
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("raw_metrics")]
    public RawMetrics? RawMetrics { get; set; }

    [JsonPropertyName("analyzed_metrics")]
    public AnalyzedMetrics? AnalyzedMetrics { get; set; }

    [JsonPropertyName("recommendations")]
    public Recommendations? Recommendations { get; set; }

    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }
}

public class RawMetrics
{
    [JsonPropertyName("cpu_count")]
    public int CpuCount { get; set; }

    [JsonPropertyName("cpus")]
    public List<CpuInfo> Cpus { get; set; } = new();

    [JsonPropertyName("total_memory_gb")]
    public double TotalMemoryGb { get; set; }

    [JsonPropertyName("used_memory_gb")]
    public double UsedMemoryGb { get; set; }

    [JsonPropertyName("available_memory_gb")]
    public double AvailableMemoryGb { get; set; }

    [JsonPropertyName("memory_usage_percentage")]
    public double MemoryUsagePercentage { get; set; }

    [JsonPropertyName("disks")]
    public List<DiskInfo> Disks { get; set; } = new();
}

public class CpuInfo
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("usage")]
    public float Usage { get; set; }
}

public class DiskInfo
{
    [JsonPropertyName("mount_point")]
    public string MountPoint { get; set; } = string.Empty;

    [JsonPropertyName("total_gb")]
    public double TotalGb { get; set; }

    [JsonPropertyName("available_gb")]
    public double AvailableGb { get; set; }

    [JsonPropertyName("used_gb")]
    public double UsedGb { get; set; }
}

public class AnalyzedMetrics
{
    [JsonPropertyName("cpu")]
    public CpuAnalysis Cpu { get; set; } = new();

    [JsonPropertyName("memory")]
    public MemoryAnalysis Memory { get; set; } = new();

    [JsonPropertyName("storage")]
    public List<StorageAnalysis> Storage { get; set; } = new();
}

public class CpuAnalysis
{
    [JsonPropertyName("core_count")]
    public int CoreCount { get; set; }

    [JsonPropertyName("average_usage")]
    public double AverageUsage { get; set; }

    [JsonPropertyName("usage_per_core")]
    public List<double> UsagePerCore { get; set; } = [];

    [JsonPropertyName("high_usage_cores")]
    public List<int> HighUsageCores { get; set; } = [];
}

public class MemoryAnalysis
{
    [JsonPropertyName("total_gb")]
    public double TotalGb { get; set; }

    [JsonPropertyName("used_gb")]
    public double UsedGb { get; set; }

    [JsonPropertyName("available_gb")]
    public double AvailableGb { get; set; }

    [JsonPropertyName("usage_percentage")]
    public double UsagePercentage { get; set; }

    [JsonPropertyName("pressure_level")]
    public string PressureLevel { get; set; } = string.Empty;
}

public class StorageAnalysis
{
    [JsonPropertyName("mount_point")]
    public string MountPoint { get; set; } = string.Empty;

    [JsonPropertyName("total_gb")]
    public double TotalGb { get; set; }

    [JsonPropertyName("available_gb")]
    public double AvailableGb { get; set; }

    [JsonPropertyName("used_gb")]
    public double UsedGb { get; set; }

    [JsonPropertyName("usage_percentage")]
    public double UsagePercentage { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
}

public class Recommendations
{
    [JsonPropertyName("critical_issues")]
    public List<string> CriticalIssues { get; set; } = new();

    [JsonPropertyName("performance")]
    public List<string> Performance { get; set; } = new();

    [JsonPropertyName("optimization")]
    public List<string> Optimization { get; set; } = new();

    [JsonPropertyName("upgrade_recommendations")]
    public List<string> UpgradeRecommendations { get; set; } = new();
}