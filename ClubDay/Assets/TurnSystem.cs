using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public bool isPlayerTurn;
    int numOfTurns = 0; //every enemy turn is +1 turn

    public CharacterInfo currentCharacter;
    public Enemy currentEnemy;

    public Selecter selecter;



    // Input
 

    
       
    // Start is called before the fist frame update
    void Start()
    {
        isPlayerTurn = true;
       
       
      

    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlayerTurn)
        {
            selecter.enabled = false;
        }
    }

    public void Check()
    {

    }

    void ChangeTurn()
    {

       if (isPlayerTurn)
        {
            isPlayerTurn=false;
        }
        else
        {
            isPlayerTurn=true;
        }
    }
}
