namespace ProcessOrchestrator.Engine.Core.Definition;

using ProcessOrchestrator.Engine.Core.Enums;
public sealed class ProcessPolicy
{
    //prod: live, test: simulation
    public ExecutionMode AllowedExecutionModes { get; set; } = ExecutionMode.Live | ExecutionMode.Simulation | ExecutionMode.Documentation;
    
    //default for execution context if not specified
    public TelemetryLevel DefaultTelemetry { get; set; } = TelemetryLevel.Verbose;

    //whether effectful actions like sending emails, writing to DB, calling APIs are allowed
    public bool AllowEffectfulActions { get; set; } 
    public bool AllowSimulatedActions { get; set; } 

    public bool RequiresAuthentication { get; set; } 
    public string? RequiredRole { get; set; }

    //engine validates, if a step has higher MaxRetries than global, use global as upper bound.
    public int? GlobalMaxRetries { get; set; }

    //engine validates with timer, throws if exceeded, cancellation token triggered
    public TimeSpan? GlobalTimeout { get; set; } 
}
