using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CreateSpawner;

public class CrateMovement : MonoBehaviour
{
    private Rigidbody2D crateRB;

    private void Awake()
    {
        crateRB = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        crateRB.velocity = new Vector2(0f, -crateSpeed);
    }
}
