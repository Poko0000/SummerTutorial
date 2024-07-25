using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateManager<PlayerStateMachine.PlayerState>
{
    public enum PlayerState
    {
        Idle,
        Move,
        Shoot
    }

    private void Awake()
    {
        CurrentState = States[PlayerState.Idle];
    }
}
