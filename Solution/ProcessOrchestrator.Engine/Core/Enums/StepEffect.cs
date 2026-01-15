namespace ProcessOrchestrator.Engine.Core.Enums;

public enum StepEffect
{
    //queries or operations that do not modify state,
    //also used in simulations and documentation or replays
    ReadOnly,
    //operations that modify state or have side-effects, used in live executions
    Effectful,
    //operations that are only executed in simulations,
    SimulatedOnly
}
