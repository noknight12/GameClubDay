using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Abilities : MonoBehaviour
{
    int Dmg_inflicted = 0;

    CharacterInfo user;
    Enemy target;
    Enemy Enemy_user;
    CharacterInfo Enemy_target;
    public StatusEffect statusEffect;
    public StatusManager statusManager;
    public StatusObjects statusObjects;
    public IsCharging IsCharging;
    private System.Random random = new System.Random();


    // Start is called before the first frame upda
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }



    public void RunEnemyAbility(string abilityName, CharacterInfo Enemy_target, Enemy user)
    {
        this.Enemy_target = Enemy_target;
        Invoke(abilityName, 0.0f);
    }

    public void RunCharAbility(string abilityName, Enemy target, CharacterInfo user) 
    {
        this.target = target;
        Invoke(abilityName, 0.0f);
    }


    //gotta put the animations in for all of this stuff sigh
    //Rangers Moves
    void Range_Normal()
    {
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Range_Heavy()
    {
        Dmg_inflicted = 40;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Range_AOE()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 0, "RangerAOE", statusEffect, false));
        Dmg_inflicted = 20; 
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }

    //fix ranger charge
    void Range_Charge()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 0, "RangeCharge", statusEffect, false));
        IsCharging = new IsCharging(true, 1); // Assuming 2 is the duration for charging
       //ranger charage is treated like a 1 move status efect so next turn it would run the code to run the animation and etc

        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Range_ULT()
    {
        statusManager.Statuses.Add(new StatusObjects(3, 3, "RangerUlt", statusEffect, false));
        //doubles his attack, can treat it like a stutus for simplicity sake
        //aoe atack on all targets same dmg
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }


    //Tank Moves
    void Tank_Normal()
    {
        Dmg_inflicted = 30;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Tank_Block()
    {
        statusManager.Statuses.Add( new StatusObjects (4, 3, "TankBlock", statusEffect , false ));
        //blocks for a character for that turn, treat as a status effect.
        user = null;
        target = null;
    }
    void Tank_Bash()
    {
        // runs a 75 percent chance to apply a status effect of stunned on its target
        if (random.NextDouble() < 0.75)
        {
            statusManager.Statuses.Add(new StatusObjects(5, 2, "TankStun", statusEffect, false));
        }
        Dmg_inflicted = 50;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Tank_Heavy()
    {
        Dmg_inflicted = 50;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }

    //tank reflect is weird priority wise
    void Tank_Reflect()
    {
        //requires use of aggro, followed by block to unlock this move. 
        statusManager.Statuses.Add(new StatusObjects(3, 1, "TankReflect", statusEffect, false));
        Dmg_inflicted = 20;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    //is also kinda werid
    void Tank_Ult()
    {
        statusManager.Statuses.Add(new StatusObjects(4, 2, "TankStun", statusEffect, false));
        statusManager.Statuses.Add(new StatusObjects(4, 1, "TankBossStun", statusEffect, false));
        // Big shield bash minions stunned for 2 turn, boss for 1 turn (AOE), treat stun like status effect
        Dmg_inflicted = 60;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }



    //Mage Moves
    void Mage_Heal()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 0, "MageHeal", statusEffect, false));
        //heal is a status effect that takes place immedetly and heals for 40 percent of character hp
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Mage_Normal()
    {
        Dmg_inflicted = 40;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }
    void Mage_heavy()
    {
        Dmg_inflicted = 60;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }

    void Mage_Dispell_AOE()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 0, "MageDispel", statusEffect, false));
        //Casts a status effect, that checks if the statuses of the heros or enemies are dispealable, and then executes.
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }

    void Mage_Mist_AOE()
    {
        /* Deal small amount of damage over a time to enemies and lowers attack
          and dmg from enemies by 20 percent (2 turns) called "cold status effect"*/
        // on the minions will skip a turn with the "frozen" status
        statusManager.Statuses.Add(new StatusObjects(1, 3, "MageAoeDOT", statusEffect, false));
        statusManager.Statuses.Add(new StatusObjects(2, 1, "MageFrozen", statusEffect, false));
        statusManager.Statuses.Add(new StatusObjects(1, 2, "MageCold", statusEffect, false));
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }

    void Mage_ULT()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 0, "MageFireball", statusEffect, false));
        statusManager.Statuses.Add(new StatusObjects(1, 4, "MageBurn", statusEffect, false));

        Dmg_inflicted = 200;
        target.Dmg_Taken = Dmg_inflicted;
        user = null;
        target = null;
    }

//aaa

    //Boss Moves
    void Boss_Summon()
    {
       
        //obviously status effect on the dead invisable minions that runs animation and sets hp to full for minions
      //  target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }
    void Boss_Normal()
    {
        statusManager.Statuses.Add(new StatusObjects(1, 3, "BossPoison", statusEffect, true));
        //applies "poison" status effect makes target lose 5 percent hp each turn for 2 turns 
        Dmg_inflicted = 50;
       // target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }
    void Boss_Heavy()
    {
        statusManager.Statuses.Add(new StatusObjects(1, 3, "BossPoison", statusEffect, true));
        statusManager.Statuses.Add(new StatusObjects(5, 0, "BossHeavy", statusEffect, false));

        //inflicts "poisoin"
        //aoe applies status effect " Boss_heavy" on the side targets that deals 50 percent of dmg the dmg inflicted on orignial target
        Dmg_inflicted = 70; 
       // target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }
    void Boss_ULT()
    {
        IsCharging = new IsCharging(true, 5); // Assuming 2 is the duration for charging
        statusManager.Statuses.Add(new StatusObjects(1, 5, "BossPoison", statusEffect, false));


        //applies boss ult status effect that deals 50 percent of damage on the first turn and 50 percent as dot spred over 5 turns
        //inficts "shock" status effect which lowers defense by some percent for 3 turns
        Dmg_inflicted = 100; 
       // target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }
    void Boss_Shield()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 10, "BossShield", statusEffect, false));
        //a shield status effects that needs 5 hits/instances of dmg to break 
        // target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }
    void Boss_Blind()
    {
        statusManager.Statuses.Add(new StatusObjects(4, 2, "BossBlind", statusEffect, true));
        //Blinds units for 2 turns lowering accuracy of characters to 50%
        Enemy_user = null;
        Enemy_target = null;
    }


    //Minions stuff
    void Minions_Normal()
    {
       // target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }
    void Minons_Heavy()
    {
        statusManager.Statuses.Add(new StatusObjects(5, 0, "MinionsHeavyAttackCharge", statusEffect, false));
        //normal but 1.75 dmg of regular normal attack
        //only actives if the minion has used 2 normal attacks prior 
        // target.Dmg_TakenChar = Dmg_inflicted;
        Enemy_user = null;
        Enemy_target = null;
    }

    
}