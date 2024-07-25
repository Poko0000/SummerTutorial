using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState_Idle : State<PlayerStateMachine.PlayerState>
{
    PlayerStateMachine.PlayerState nextState = PlayerStateMachine.PlayerState.Idle;

    public PlayerState_Idle(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Idle;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Idle State");
    }
    public override void UpdateState()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            nextState = PlayerStateMachine.PlayerState.Move;
        }
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
