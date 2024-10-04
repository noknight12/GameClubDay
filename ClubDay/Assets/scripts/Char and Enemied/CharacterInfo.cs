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

    public bool isAlive;

    public bool isMage;
    public bool isTank;
    public bool isRange;

    public CardGroup CardGroup;
    public Card characterCard;
    public CardGroup abilityCards;

    public float atkMultiplier;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
