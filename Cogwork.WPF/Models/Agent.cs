namespace Cogwork.WPF.Models;

public enum AgentState
{
    Idle,
    Thinking,
    Responding
}

internal class Agent(Content.Agent agent)
{
    private readonly Content.Agent _data = agent;
    public string Name => _data.Name;
    public string Prompt => _data.Prompt;

    public AgentState State { get; set; } = AgentState.Idle;
}
