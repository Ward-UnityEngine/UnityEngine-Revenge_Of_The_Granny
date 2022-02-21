using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CreateSpawner;

public class DistanceTracker : MonoBehaviour
{
    public float distance = 0;
    public DistanceTextUI distanceTextUI;




    

    private void Update()
    {
        distance += Time.deltaTime * crateSpeed;
        distanceTextUI.UpdateText(distance);
    }
}
