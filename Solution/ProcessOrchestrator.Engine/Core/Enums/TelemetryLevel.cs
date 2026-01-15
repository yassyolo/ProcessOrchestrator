namespace ProcessOrchestrator.Engine.Core.Enums;

public enum TelemetryLevel
{
    //used in live executions with minimal events stored, e.g. errors only
    //basic telemetry for production(latency, success/failure rates, retries, resource usage)
    //low overhead, longer retention
    Minimal,
    //standard telemetry with detailed events, e.g. step start/end, retries
    Verbose,
    //full telemetry with all events, e.g. input/output data, intermediate states
    Simulation
}
