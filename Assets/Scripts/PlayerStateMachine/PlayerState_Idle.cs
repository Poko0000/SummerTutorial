using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState_Idle : State<PlayerStateMachine.PlayerState>
{
    PlayerStateMachine.PlayerState nextState;

    public PlayerState_Idle(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Idle;
        nextState = key;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Idle State");
        nextState = PlayerStateMachine.PlayerState.Idle;
    }
    public override void UpdateState()
    {
        if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0)
        {
            nextState = PlayerStateMachine.PlayerState.Move;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            nextState = PlayerStateMachine.PlayerState.Shoot;
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
