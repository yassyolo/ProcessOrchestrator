namespace ProcessOrchestrator.Engine.Core.Definition;

public class ProcessDefinition
{
    public Guid Id { get; }

    //used in register by IProcessRegistry.Get(name, version), UI display
    public string Name { get; }
    public string Version { get; }

    //steps in the process
    //UI: display in order added
    //Documentation: UML activity diagram
    public IReadOnlyCollection<ProcessStepDefinition> Steps => _steps.AsReadOnly();
    private readonly List<ProcessStepDefinition> _steps = new();

    //validation: must have a start step
    public string StartStepId { get; internal set; }

    public ProcessMetadata Metadata { get; }

    //validate: security, telemetry
    public ProcessPolicy Policy { get; } = new();

    public bool IsEnabled { get; set; } = true;

    //UI: filter by category
    public string? Category { get; set; }

    //UI: filter by tags
    public IReadOnlyCollection<string> Tags { get; }

    public ProcessDefinition(
        string name,
        string version,
        bool sensitive)
    {
        Name = name;
        Version = version;

        Metadata = new ProcessMetadata(sensitive);
    }

    internal void AddStep(ProcessStepDefinition step) => _steps.Add(step);
}
