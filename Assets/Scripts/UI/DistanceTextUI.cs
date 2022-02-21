using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PlayerCollisions;


public class DistanceTextUI : MonoBehaviour
{
    public Text distanceText;

    

    public void UpdateText(float distance)
    {
       
            distance = Mathf.RoundToInt(distance);
            distanceText.text = (distance.ToString() + " m");
        
    }

}
