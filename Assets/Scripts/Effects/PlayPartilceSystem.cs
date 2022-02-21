using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPartilceSystem : MonoBehaviour
{
    private ParticleSystem particleSystemCrate;

    private void Awake()
    {
        particleSystemCrate = GetComponent<ParticleSystem>();
    }
    private void Start()
    {
      
        particleSystemCrate.Play();
    }
}
