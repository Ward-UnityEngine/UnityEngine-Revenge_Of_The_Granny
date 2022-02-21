using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightningEffect : MonoBehaviour
{

    private Light2D lights;

    public float standardLighting;
    public float lightningLighting;
    public float lightningDuration;
    public int amountOfStrikes;

    private int strikeNumb = 0;
    private bool isLit = false;

    //Lightning interval
    public int minStrikeTime;
    public int maxStriketime;
    

    private void Awake()
    {
        lights = GetComponent<Light2D>();
    }

    private void Start()
    {
        lights.intensity = standardLighting;
        Invoke("StartCourotine", GetNextStrikeTime());

    }

    private void StartCourotine()
    {
        strikeNumb = 0;
        StartCoroutine(LightningStrike());
        
        Invoke("StartCourotine", GetNextStrikeTime());
    }

    private int GetNextStrikeTime()
    {
        //Debug.Log("next strike time " + UnityEngine.Random.Range(minStrikeTime, maxStriketime));
        return UnityEngine.Random.Range(minStrikeTime, maxStriketime);
    }
   

    private IEnumerator LightningStrike()
    {
        while (strikeNumb < amountOfStrikes)
        {


            if (!isLit)
            {
                lights.intensity = lightningLighting;
                yield return new WaitForSeconds(lightningDuration);
                isLit = true;
            }
            else
            {
                lights.intensity = standardLighting;
                yield return new WaitForSeconds(lightningDuration);
                strikeNumb++;
                isLit = false;
            }
            

        }
    }
    
}
