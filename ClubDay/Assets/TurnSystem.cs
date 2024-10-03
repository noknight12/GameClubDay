using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public bool isPlayerTurn;

    public CharacterInfo currentCharacter;
    public Enemy currentEnemy;

    bool isRangerAvaiable = true;
    bool isKnightAvaiable = true;
    bool isWizardAvaiable = true;



    // Input
 

    
       
    // Start is called before the fist frame update
    void Start()
    {
        isPlayerTurn = true;
       

        isWizardAvaiable = true;
        isKnightAvaiable = true;
        isWizardAvaiable = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()
    {
        if(!isRangerAvaiable &&  !isKnightAvaiable && !isWizardAvaiable) 
        {
            ChangeTurn();
        }
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
