namespace ProcessOrchestrator.Engine.Core.Definition;

using ProcessOrchestrator.Engine.Core.Enums;
using ProcessOrchestrator.Engine.Executin;

public sealed class ProcessStepDefinition
{
    public string Id { get; }
    public string Name { get; set; }

    public Type ActionType { get; }

    public StepKind Kind { get; set; } = StepKind.Normal;
    public StepEffect Effect { get; set; } = StepEffect.Effectful;

    public int? MaxRetries { get; set; }
    public TimeSpan? Timeout { get; set; }

    private readonly List<TransitionDefinition> _transitions = new();
    public IReadOnlyCollection<TransitionDefinition> Transitions => _transitions.AsReadOnly();

    internal Func<IProcessExecutionContext, IServiceProvider, CancellationToken, Task> Executor { get; private set; }

    public ProcessStepDefinition(
        string id,
        Func<IProcessExecutionContext, IServiceProvider, CancellationToken, Task> executor)
    {
        Id = id;
        Executor = executor;
    }

    internal void AddTransition(TransitionDefinition transition)
        => _transitions.Add(transition);

    internal void SetExecutor(Func<IProcessExecutionContext, IServiceProvider, CancellationToken, Task> executor)
        => Executor = executor;
}
