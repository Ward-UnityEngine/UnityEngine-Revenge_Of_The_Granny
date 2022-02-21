using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpawner : MonoBehaviour
{
    public GameObject crateA;
    public GameObject crateB;

    public Transform leftBorder;
    public Transform rightBorder;

    public float spawnTime;

    public static float crateSpeed = 5;
    private float spawnPosX;
    private float whichCrate;
    private float amountOfSpawnedcrates = 0; //Whit this value we will speed up the game gradually
    public float speedIncreaser;
    public float amountIncreaser;
    private float timesTheAmountGotIncreased = 0;

    private void Start()
    {
        StartCoroutine(spawnCrates());
        StartCoroutine(IncreaseDifficulty());
    }

    private IEnumerator spawnCrates()
    {
        while (true)
        {
            whichCrate = Random.Range(0, 2);
            
            if (whichCrate == 1)
            {
                spawnPosX = Random.Range(leftBorder.position.x, rightBorder.position.x);
                Instantiate(crateA, new Vector3(spawnPosX, rightBorder.position.y, 0), Quaternion.identity);
                yield return new WaitForSeconds(spawnTime);
                
            }
            else
            {
                spawnPosX = Random.Range(leftBorder.position.x, rightBorder.position.x);
                Instantiate(crateB, new Vector3(spawnPosX, rightBorder.position.y, 0), Quaternion.identity);
                yield return new WaitForSeconds(spawnTime);
            }

            
        }
    }

    private IEnumerator IncreaseDifficulty()
    {
        crateSpeed += speedIncreaser;
        spawnTime -= amountIncreaser;
        amountIncreaser = amountIncreaser * 0.9f;
        yield return new WaitForSeconds(10f);
    }

    
    /*
    private void IncreaseSpeed()
    {
        
    }
    private void IncreaseAmount()
    {
        if (amountOfSpawnedcrates >= 20)
        {
            amountOfSpawnedcrates = 0;
            spawnTime -= amountIncreaser;
            if (timesTheAmountGotIncreased >= 5)
            {
                timesTheAmountGotIncreased = timesTheAmountGotIncreased * 0.5f;
                timesTheAmountGotIncreased = 0;
            }
            else
            timesTheAmountGotIncreased++;

        }

        else 
        {
            amountOfSpawnedcrates++;
        }
    }*/
}

