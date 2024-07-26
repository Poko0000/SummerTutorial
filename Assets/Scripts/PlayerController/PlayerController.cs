using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float speed = 5;

    private void Awake()
    {             
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        SetVelocityX(horizontalInput * speed);
        float verticalInput = Input.GetAxis("Vertical");
        SetVelocityY(verticalInput * speed);

    }

    public void SetVelocity(Vector3 velocity)
    {
        rigidbody.velocity = velocity;
    }

    public void SetVelocityX(float velocityX)
    {
        rigidbody.velocity = new Vector3(velocityX, rigidbody.velocity.y);
    }

    public void SetVelocityY(float velocityY)
    {
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, velocityY);
    }
}
