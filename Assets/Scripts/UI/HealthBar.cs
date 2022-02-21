using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider slider;

    public float maxHealth;
    public float currentHealth;

    

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    private void Start()
    {
        currentHealth = maxHealth;
        slider.value = currentHealth;
    }

    public void SetHealth(float health)
    {
        
        currentHealth += health;
       
            slider.value = currentHealth;
        
    }
}
