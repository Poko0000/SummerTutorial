using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState_Move : State<PlayerStateMachine.PlayerState>
{
    PlayerStateMachine.PlayerState nextState;

    public PlayerState_Move(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Move;
        nextState = key;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Move State");
        nextState = PlayerStateMachine.PlayerState.Move;
    }
    public override void UpdateState()
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            nextState = PlayerStateMachine.PlayerState.Idle;
        }
        else if(Input.GetMouseButtonDown(0))
        {
            nextState = PlayerStateMachine.PlayerState.Shoot;
        }

        controller.Move();       
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
