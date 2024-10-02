using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : CharacterInfo
{
    public int Dmg_TakenChar_t;
    public int health_t;
    public int stamina_t;
    public int mana_t;
    public int numberOfAbilities_t;


    // Start is called before the first frame update
    void Start()
    {
        Dmg_TakenChar = Dmg_TakenChar_t;
        health = health_t;
        stamina = stamina_t;
        mana = mana_t;
        numberOfAbilities = numberOfAbilities_t;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
