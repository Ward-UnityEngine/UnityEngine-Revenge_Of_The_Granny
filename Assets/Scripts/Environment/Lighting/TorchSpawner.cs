using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TorchSpawner : MonoBehaviour
{
    public GameObject torchLeft;
    public GameObject torchRight;

    public Transform torchLeftTR;
    public Transform torchRightTR;

    public float waitTimeTorchSpawner;
    public bool spawnTorchers = true;
    private void Start()
    {
        StartCoroutine(SpawnTorches());
    }

    private IEnumerator SpawnTorches()
    {
        while (spawnTorchers)
        {
            Instantiate(torchLeft, torchLeftTR.position,torchLeftTR.rotation);
            Instantiate(torchRight, torchRightTR.position,torchLeftTR.rotation);
            yield return new WaitForSeconds(waitTimeTorchSpawner);
        
        }
    }
}
