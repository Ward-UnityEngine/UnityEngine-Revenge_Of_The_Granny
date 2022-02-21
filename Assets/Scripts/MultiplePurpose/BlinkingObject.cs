
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerCollisions;


public class BlinkingObject : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;
    private bool isVisible = true;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Blink(float time)
    {
        StartCoroutine(ActualBlink(time));
        
    }

    IEnumerator ActualBlink(float waitTime){
        //bool firstTime = true;
        //Debug.Log("coroutine has been started");
        float endTime = Time.time + waitTime;
        //Debug.Log(" Time.time " + Time.time + " waitTime  " + waitTime);
        while (Time.time < endTime)
        {
            /*if (firstTime)
                yield return new WaitForSeconds(0.2f);*/
            //Debug.Log("while is true");
            spriteRenderer.enabled = false;
            
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }

        PlayerCollisions.playerIsInvincible = false;
        
    }

    
}
