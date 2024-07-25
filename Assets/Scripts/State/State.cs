using UnityEngine;
using System;
using Unity.VisualScripting;

public abstract class State<EState> where EState : Enum
{
    public EState StateKey { get; private set; }
    public State(EState key)
    {
        StateKey = key;
    }
    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
    public abstract EState GetNextState();
    public abstract void OnTriggerEnter2D(Collider2D collision);
    public abstract void OnTriggerStay2D(Collider2D collision); 
    public abstract void OnTriggerExit2D(Collider2D collision);
}
