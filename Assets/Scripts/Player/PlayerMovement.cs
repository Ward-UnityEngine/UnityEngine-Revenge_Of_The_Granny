using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;

    
    public float movementSpeed;
    

    
    private Vector2 targetDirection;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        targetDirection.x = Input.GetAxisRaw("Horizontal");
        targetDirection.y = Input.GetAxisRaw("Vertical");
        //Debug.Log(movementDirection);
    }

    private void FixedUpdate()
    {

        playerRB.velocity = targetDirection * movementSpeed * Time.deltaTime;

    }
}
