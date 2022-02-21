using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public HealthBar healthBar;
    public SceneManagementScript sceneManagementScript;
    public BlinkingObject blinkingObject;
    public GameObject deathscreen;
    public GameObject distanceTracker;
    public static bool playerIsInvincible = false;
   


    public Collider2D playerCollider;
    public Collider2D slamDunkCollider;

    public GameObject crateParticleSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collision");
        if (collision.CompareTag("Obstacle") && (!playerIsInvincible))
        {
            PlayerGotDammaged();
            Destroy(collision.gameObject);
            //Instantiate Effect of crate getting destroyed
            Instantiate(crateParticleSystem, collision.transform.position, Quaternion.identity);
            //Check whether the player has got remaining health
            
        }

        
    }

    private void PlayerGotDammaged()
    {
        healthBar.SetHealth(-25);
        if (healthBar.currentHealth < 0)
        {
            //Reset Level
            deathscreen.SetActive(true);
            distanceTracker.SetActive(false);
            
            
        }
        else
        {
            blinkingObject.Blink(3f);
            playerIsInvincible = true;
        }
    }

    public void CheckForOverlapSlamDunk()
    {
        if (Physics2D.IsTouching(playerCollider, slamDunkCollider))
        {
            PlayerGotDammaged();
        }
        
    }
    

    private void ResetLevel()
    {
        sceneManagementScript.RestartLevel();
    }
}
