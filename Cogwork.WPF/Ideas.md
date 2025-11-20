# PsudoCode

## General
- visual nodes for each agent
- visual nodes for each bucket (reviews, tasks)
- listeners that agents can subscribe to for updates on their buckets
- visualize the connections between agents and their buckets
- visualize the flow of tasks and reviews between agents and buckets
- visualize agent state (idle, thinking, Responding)
- Gemini-CLI integration for managing agents

## Agent controls
- New agents => CRUD with save to file
- Agent Frequency, how often each planner is called. 

## Human API
- Handle Human context files => CRUD for scope, roadmap and other context files. Planners will consume as part of their prompts. 
- Handle Human warnings bucket. 

## LLM Manager (Optional based on model availability) 
- Track llm usage by model
- Prioretize specific model usage per agent