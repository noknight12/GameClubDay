using System;

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossAI : Enemy
{
    public int HP_Boss;
    public int Defence_Boss;
    public int AtkMulti_Boss;
    public string[] randomString;
    public string selectedString;
    public Abilities abilities;
    public int currentTurn;
    public TurnSystem turnSystem;
    // cooldowns
    public int boss_normal;
    public int boss_heavy;
    public int boss_blind;
    public int boss_shield;
    public int boss_summon;
    public int boss_ult;

    // Start is called before the first frame update
    void Start()
    {
        
        HP_Boss = HP; 
        Defence_Boss = Defence;
        AtkMulti_Boss = AtkMulti;
        boss_summon = 4;
        boss_ult = 5;
    }
    void Boss_Think()
    {
        ChooseRandomChar();
        chooseAtk();

    }
    void ChooseRandomChar()
    {
        if (randomString.Length == 0)
        {
            Debug.LogError("No strings assigned!");
            return;
        }

        int randomIndex = UnityEngine.Random.Range(0, randomString.Length);  
        selectedString = randomString[randomIndex];

        // Display the selected string in the console
        Debug.Log("Random String Selected: " + selectedString);
    }
    void chooseAtk()
    {
        if (boss_ult == 0)
        {
            Attack("Ult");
        } else if (boss_summon == 0)
        {
            Attack("Summon");
        }
        else if (boss_shield == 0)
        {
            Attack("Shield");
        }
        else if (boss_blind == 0)
        {
            Attack("Blind");
        }
        else if (boss_heavy == 0)
        {
            Attack("Heavy");
        }
        else if (boss_normal == 0)
        {
            Attack("Normal");
        }
    }
    void Attack(String ability)
    {
        

        switch (ability)
        {
            case "Ult":
                Debug.Log("Using Ultamite");
                boss_ult = 5;
                break;

            case "Summon":
                Debug.Log("Using Summon");
                boss_summon = 4;
                break;

            case "Shield":
                Debug.Log("Using Shield");
                boss_shield = 3;
                break;

            case "Blind":
                Debug.Log("Using Blind");
                boss_blind = 3;
                break;

            case "Heavy":
                Debug.Log("Using Heavy");
                boss_heavy = 2;
                break;

            case "Normal":
                Debug.Log("Using Normal");
                boss_normal = 1;
                break;

            default:
                Debug.LogError("Unknown Game State!");
                break;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Boss_Think();
            
            
        }
    }
}
