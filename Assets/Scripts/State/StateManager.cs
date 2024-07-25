using UnityEngine;
using System;
using System.Collections.Generic;

public abstract class StateManager<EState>  : MonoBehaviour where EState : Enum
{
    protected Dictionary<EState, State<EState>> States = new Dictionary<EState, State<EState>>();

    protected State<EState> CurrentState;

    protected bool IsTransitioningState = false;
    private void Start()
    {
        CurrentState.EnterState();
    }
    private void Update()
    {
        EState nextStateKey = CurrentState.GetNextState();
        if(!IsTransitioningState && nextStateKey.Equals(CurrentState.StateKey)) 
        { 
            CurrentState.UpdateState();
        }
        else if(!IsTransitioningState)
        {
            TransitionToState(nextStateKey);
        }
    }

    public void TransitionToState(EState stateKey)
    {
        IsTransitioningState = true;
        CurrentState.ExitState();
        CurrentState = States[stateKey];
        CurrentState.EnterState();
        IsTransitioningState = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CurrentState.OnTriggerEnter2D(collision);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        CurrentState.OnTriggerStay2D(collision);
    }
    private void OnTriggerExit2D(Collider2D collision)
    { 
        CurrentState.OnTriggerExit2D(collision);
    }
}
