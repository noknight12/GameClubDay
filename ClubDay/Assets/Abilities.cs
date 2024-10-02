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
        Dmg_inflicted = 40;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_AOE(CharacterInfo user, Enemy target)
    {
        //involves status effect so speical work on laterr
        //aoe involves main damage on the target and less secondary dmg on the enemies next to it
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_Charge(CharacterInfo user, Enemy target)
    {
        //ranger charage is treated like a 1 move status efect so next turn it would run the code to run the animation and etc
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Range_ULT(CharacterInfo user, Enemy target)
    {
        //doubles his attack, can treat it like a stutus for simplicity sake
        //aoe atack on all targets same dmg
        //
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }


    //Tank Moves
    void Tank_Normal(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 30;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Block(CharacterInfo user, Enemy target)
    {
        //blocks for a character for that turn, treat as a status effect.
    }
    void Tank_Bash(CharacterInfo user, Enemy target)
    {
        // runs a 75 percent chance to apply a status effect of stunned on its target
       
        Dmg_inflicted = 50;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Heavy(CharacterInfo user, Enemy target)
    {

        Dmg_inflicted = 50;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Reflect(CharacterInfo user, Enemy target)
    {
        //requires use of aggro, followed by block to unlock this move. 
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Tank_Ult(CharacterInfo user, Enemy target)
    {
         // Big shield bash minions stunned for 2 turn, boss for 1 turn (AOE), treat stun like status effect
        Dmg_inflicted = 60;
        target.Dmg_Taken = Dmg_inflicted;
    }



    //Mage Moves
    void Mage_Heal(CharacterInfo user, Enemy target)
    {
        //heal is a status effect that takes place immedetly and heals for 40 percent of character hp
        //over heal up to 20 percent of hp can be converted to a sheild which unless broken will break in 3 turns, treat like a status effect
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Mage_Normal(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 40;
        target.Dmg_Taken = Dmg_inflicted;
    }
    void Mage_heavy(CharacterInfo user, Enemy target)
    {
        Dmg_inflicted = 60;
        target.Dmg_Taken = Dmg_inflicted;
    }

    void Mage_Dispeal_AOE(CharacterInfo user, Enemy target)
    {
        //Casts a status effect, that checks if the statuses of the heros or enemies are dispealable, and then executes.
        target.Dmg_Taken = Dmg_inflicted;
    }

    void Mage_Mist_AOE(CharacterInfo user, Enemy target)
    {
        /* Deal small amount of damage over a time to enemies and lowers attack
          and dmg from enemies by 20 percent (2 turns) called "cold status effect"*/
        // on the minions will skip a turn with the "frozen" status
        target.Dmg_Taken = Dmg_inflicted;
    }

    void Mage_ULT(CharacterInfo user, Enemy target)
    {
        //Check if enemies are inflicted with cold status effect and if true doubles the dmg output
        Dmg_inflicted = 100;
        target.Dmg_Taken = Dmg_inflicted;
    }

//aaa

    //Boss Moves
    void Boss_Summon(Enemy user, CharacterInfo target)
    {
        //obviously status effect on the dead invisable minions that runs animation and sets hp to full for minions
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_Normal(Enemy user, CharacterInfo target)
    {
        //applies "bleeding" status effect makes target lose 5 percent hp each turn for 2 turns 
        Dmg_inflicted = 50;
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_Heavy(Enemy user, CharacterInfo target)
    {
        //inflicts "bleeding"
        //aoe applies status effect " Boss_heavy" on the side targets that deals 50 percent of dmg the dmg inflicted on orignial target
        Dmg_inflicted = 70; 
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_ULT(Enemy user, CharacterInfo target)
    {
        //applies boss ult status effect that deals 50 percent of damage on the first turn and 50 percent as dot spred over 5 turns
        //inficts "shock" status effect which lowers defense by some percent for 3 turns
        Dmg_inflicted = 100; 
        target.Dmg_TakenChar = Dmg_inflicted;
    }
    void Boss_Shield(Enemy user, CharacterInfo target)
    {
        //a shield status effects that needs 5 hits/instances of dmg to break 
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
        //only actives if the minion has used 2 normal attacks prior 
        target.Dmg_TakenChar = Dmg_inflicted;
    }
}