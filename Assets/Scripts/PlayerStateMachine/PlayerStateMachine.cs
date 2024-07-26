using System;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;
using static UnityEditor.VersionControl.Asset;

public class PlayerStateMachine : StateManager<PlayerStateMachine.PlayerState>
{    
    public enum PlayerState
    {
        Idle,
        Move,
        Shoot
    }

    private PlayerState_Idle idleState = new PlayerState_Idle(PlayerState.Idle);
    private PlayerState_Move moveState = new PlayerState_Move(PlayerState.Move);
    private PlayerState_Shoot shootState = new PlayerState_Shoot(PlayerState.Shoot);

    PlayerController controller;

    public State<PlayerState>[] playerStates;
    
    private void Awake()
    {
        controller = GetComponent<PlayerController>();

        idleState.Initialize(controller);
        moveState.Initialize(controller);
        shootState.Initialize(controller);

        States.Add(PlayerState.Idle, idleState);
        States.Add(PlayerState.Move, moveState);
        States.Add(PlayerState.Shoot, shootState);
    }

    private void Start()
    {
        CurrentState = States[PlayerState.Idle];
    }
}
