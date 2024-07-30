using UnityEngine;

public class PlayerState_Shoot : State<PlayerStateMachine.PlayerState>
{
    PlayerStateMachine.PlayerState nextState;

    public PlayerState_Shoot(PlayerStateMachine.PlayerState key) : base(key)
    {
        key = PlayerStateMachine.PlayerState.Shoot;
        nextState = key;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Shoot State");
        nextState = PlayerStateMachine.PlayerState.Shoot;
    }
    public override void UpdateState()
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            nextState = PlayerStateMachine.PlayerState.Idle;
        }
        else if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0)
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
