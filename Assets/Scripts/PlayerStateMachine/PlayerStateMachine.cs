using Unity.VisualScripting;
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

    private void Awake()
    {
        States.Add(PlayerState.Idle, idleState);
        States.Add(PlayerState.Move, moveState);
        States.Add(PlayerState.Shoot, shootState);

        CurrentState = States[PlayerState.Idle];

    }
}
