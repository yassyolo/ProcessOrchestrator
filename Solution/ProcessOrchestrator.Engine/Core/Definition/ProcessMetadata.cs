namespace ProcessOrchestrator.Engine.Core.Definition;

#nullable enable

public class ProcessMetadata
{
    //documentation
    //UI: display
    public string Description { get; set; } 

    public string? CreatedBy { get; set; }

    //UI: show history of processes(timeline)
    public DateTime CreatedAt { get; set; }

    public DateTime? LastModifiedAt { get; set; }

    //indicates if the process contains sensitive information,
    //used for masking in logs and telemetry and smaller retention policies
    //UI: show warning if sensitive
    public bool Sensitive { get; set; } = false;

    //Link to external documentation or system
    public string? ExternalId { get; set; }

    public ProcessMetadata(bool sensitive)
    {
        Sensitive = sensitive;

        CreatedAt = DateTime.UtcNow;
    }
}
