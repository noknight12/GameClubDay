using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Abilities : MonoBehaviour
{
    int Dmg_inflicted = 0;


    // Start is called before the first frame upda
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    
    //gotta put the animations in for all of this stuff sigh
    //Rangers Moves
    void Range_Normal(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_Heavy(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_AOE(CharacterInfo user, Enemy target)
    {
        //involves status effect so speical work on laterr
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_Charge(CharacterInfo user, Enemy target)
    {
        //special
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_ULT(CharacterInfo user, Enemy target)
    {
        //raises dmg plus multihit attack
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }

    //Tank Moves
    void Tank_Normal(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Block(CharacterInfo user, Enemy target)
    {
        //work on laterr
    }
    void Tank_Heavy(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Reflect(CharacterInfo user, Enemy target)
    {
        //also special work on later
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Ult(CharacterInfo user, Enemy target)
    {
        //special alsoo
        target.Dmg_Taken = Dmg_inflicted;
    }

    //Mage Moves
    void Mage_Heal(CharacterInfo user, Enemy target)
    {
        //speical
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Mage_Normal(CharacterInfo user, Enemy target)
    {
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Mage_heavy(CharacterInfo user, Enemy target)
    {
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Mage_AOE(CharacterInfo user, Enemy target)
    {
        //aoe differnt
        target.Dmg_Taken = Dmg_inflicted;
    }

    void Mage_Mist_AOE(CharacterInfo user, Enemy target)
    {
        //also aoe so difffernt also has stutuses
        target.Dmg_Taken = Dmg_inflicted;
    }

    void Mage_ULT(CharacterInfo user, Enemy target)
    {
        //aoe fireball so speical
        target.Dmg_Taken = Dmg_inflicted;
    }

    //Boss Moves
    void Boss_Summon(Enemy user, CharacterInfo target)
    {
        //obviously speicla
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_Normal(Enemy user, CharacterInfo target)
    {
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_Heavy(Enemy user, CharacterInfo target)
    {
        //special aoe
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_ULT(Enemy user, CharacterInfo target)
    {
        //special
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_Shield(Enemy user, CharacterInfo target)
    {
        //speical
        target.Dmg_TakenChar = Dmg_inflicted;
    }

    //Minions stuff
    void Minions_Normal(Enemy user, CharacterInfo target)
    {
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Minons_Heavy(Enemy user, CharacterInfo target)
    {
        //normal but 1.75 dmg of regular normal attack
        target.Dmg_TakenChar = Dmg_inflicted;
    }
}