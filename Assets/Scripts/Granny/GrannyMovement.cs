using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyMovement : MonoBehaviour
{
    public Transform playerTR;
    private Rigidbody2D grannyRB;
    private Transform grannyTR;

    public float grannyMovementSpeed;
    public float maxDistance;

    private float startPositionY;

    public static bool grannyIsChasing = true;
    


    private void Awake()
    {
        grannyRB = GetComponent<Rigidbody2D>();
        grannyTR = GetComponent<Transform>();
    }

    private void Start()
    {
         startPositionY = grannyTR.position.y;
        //Debug.Log("Startposition " + startPositionY);
    }


    private void FixedUpdate()
    {
        if (grannyIsChasing)
        {

            Vector3 targetPosition = playerTR.position;
            targetPosition.y = startPositionY;
            //Debug.Log("x " + targetPosition.x + "y " + targetPosition.y + "z " + targetPosition.z);
            grannyTR.position = Vector3.MoveTowards(grannyTR.position, targetPosition, maxDistance);
        }

        
    }
}
