using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_Bar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHealth(int Health)
    {
        slider.maxValue = Health;
        slider.value = Health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;  
    }
        
}
