using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CreateSpawner;

public class TorchMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        rb.velocity = new Vector2(0f, crateSpeed * -1);
    }
}
