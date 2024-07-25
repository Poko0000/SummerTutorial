using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState_Shoot : State<PlayerStateMachine.PlayerState>
{
    public PlayerState_Shoot(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Shoot;
    }

    public override void EnterState()
    {
        throw new System.NotImplementedException();
    }
    public override void UpdateState()
    {
        throw new System.NotImplementedException();
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException();
    }

    public override PlayerStateMachine.PlayerState GetNextState()
    {
        throw new System.NotImplementedException();
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        throw new System.NotImplementedException();
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        throw new System.NotImplementedException();
    }

    public override void OnTriggerStay2D(Collider2D collision)
    {
        throw new System.NotImplementedException();
    }

}
