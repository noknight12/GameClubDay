using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : Enemy
{
    //everyturn attack normal and heavy every 2 turns
    // Start is called before the first frame update
    bool isDead;
    int heavyAttackCD = 2;
    int currentTurn = 0;
    public Abilities abilities;
    public CardGroup charGroup;

    bool doneTurn;

    public TurnSystem TurnSystem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TurnSystem.isPlayerTurn)
        {


            if (TurnSystem.numOfTurns > currentTurn)
            {
                heavyAttackCD--;

            }

            if(heavyAttackCD <= 0)
            {

            }
            else
            {

            }

        }
    }

    void ChooseTarget()
    {
        int target = Random.Range(0, 2);
        CharacterInfo enemyTarget = charGroup.cards[target].characterInfo;
    }
}



