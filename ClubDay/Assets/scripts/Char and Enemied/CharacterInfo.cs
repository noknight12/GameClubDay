using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    public int Dmg_TakenChar;
    public int health;
    public int stamina;
    public int mana;
    public int numberOfAbilities;
    public int MaxHealth;
    public bool isAlive;

    public bool isMage;
    public bool isTank;
    public bool isRange;

    public CardGroup CardGroup;
    public Card characterCard;
    public CardGroup abilityCards;

    public health_Bar health_bar;
   
    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
        //health_Bar.SetMaxHealth(MaxHealth); // Set the health bar's max value
        isAlive = true;
    }


    // Update is called once per frame
    void Update()
    {
            
    }
    public void TakeDamage(int damage)
    {
        if (isAlive)
        {
            health -= damage; // Reduce health by the damage amount

            // Check if health goes below 0 and set it to 0
            if (health < 0)
            {
                health = 0;
            }

            health_bar.SetHealth(health); // Update the health bar

            if (health <= 0)
            {
                isAlive = false; // Mark character as dead
                // Handle character death (e.g., disable the character, trigger animations, etc.)
            }
        }
    }

    // Function to heal the character
    public void Heal(int healAmount)
    {
        if (isAlive)
        {
            health += healAmount; // Increase health by the heal amount

            // Check if health exceeds max health and set it to MaxHealth
            if (health > MaxHealth)
            {
                health = MaxHealth;
            }

            health_bar.SetHealth(health); // Update the health bar
        }
    }


}
