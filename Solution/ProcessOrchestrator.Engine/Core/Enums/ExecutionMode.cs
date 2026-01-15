namespace ProcessOrchestrator.Engine.Core.Enums;

public enum ExecutionMode
{
    //normal execution with real side-effects, minimal telemetry
    Live,
    //effectful actions are simulated, no real side-effects
    Simulation,
    //validates, generates onlyd documentation/diagrams, no execution
    Documentation
}
