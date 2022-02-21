using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenHandler : MonoBehaviour
{

    public SceneManagementScript SceneManagementScript;

    // Gameobjects to be destroyed
    public GameObject crateSpawner;
    public GameObject torchSpawner;
    public GameObject granny;
    public GameObject player;

    private void OnEnable()
    {
        StopGame();
    }
    public void StopGame()
    {
        
        //Debug.Log("I'm a fluffy unicorn");
        crateSpawner.SetActive(false);
        torchSpawner.SetActive(false);
        Destroy(crateSpawner);
        Destroy(torchSpawner);
        Destroy(granny);
        Destroy(player);
    }


    public void RestartLevel()
    {
        SceneManagementScript.RestartLevel();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

