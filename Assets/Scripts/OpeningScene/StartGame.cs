using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public SceneManagment sceneManagment;
    private void Update()
    {
        if (Input.anyKeyDown) 
        {
            sceneManagment.NextLevel();
        }
    }
}
