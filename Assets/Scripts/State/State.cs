using UnityEngine;
using System;

public abstract class State<EState> where EState : Enum
{
    public PlayerController controller;

    public EState StateKey { get; private set; }
    public State(EState key)
    {
        StateKey = key;
    }
    public void Initialize(PlayerController controller)
    {
        this.controller = controller;
    }
    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
    public abstract EState GetNextState();
    public abstract void OnTriggerEnter2D(Collider2D collision);
    public abstract void OnTriggerStay2D(Collider2D collision); 
    public abstract void OnTriggerExit2D(Collider2D collision);
}
