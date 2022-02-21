using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GrannyCollisions : MonoBehaviour
{
    public GameObject crateParticleSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            
            Destroy(collision.gameObject);
            
            //Instantiate Crate Destroy Effect
            Instantiate(crateParticleSystem, collision.transform.position, Quaternion.identity);
            
                        
        }
    }
}
