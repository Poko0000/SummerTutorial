using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState_Move : State<PlayerStateMachine.PlayerState>
{
    PlayerStateMachine.PlayerState nextState = PlayerStateMachine.PlayerState.Move;

    public PlayerState_Move(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Move;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Move State");
    }
    public override void UpdateState()
    {

    }

    public override void ExitState()
    {
        
    }

    public override PlayerStateMachine.PlayerState GetNextState()
    {
        return nextState;
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    public override void OnTriggerStay2D(Collider2D collision)
    {
        
    }

}
