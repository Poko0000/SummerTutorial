
public class PlayerStateMachine : StateManager<PlayerStateMachine.PlayerState>
{    
    public enum PlayerState
    {
        Idle,
        Move,
        Shoot
    }

    private State<PlayerState> idleState = new PlayerState_Idle(PlayerState.Idle);
    private State<PlayerState> moveState = new PlayerState_Move(PlayerState.Move);
    private State<PlayerState> shootState = new PlayerState_Shoot(PlayerState.Shoot);

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
