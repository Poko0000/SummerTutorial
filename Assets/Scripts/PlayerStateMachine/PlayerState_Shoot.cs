using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerState_Shoot : State<PlayerStateMachine.PlayerState>
{
    PlayerStateMachine.PlayerState nextState = PlayerStateMachine.PlayerState.Shoot;

    public PlayerState_Shoot(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Shoot;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Shoot State");
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
