using UnityEngine;

public class StateMachine
{
    public EntityState currentState { get; private set; } //anyone can see it vut noone can assign it

    public void Initialize(EntityState startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    public void ChangeState(EntityState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void UpdateActiveState()
    {
        currentState.Update();
    }
}
