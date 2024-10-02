using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Selecter : MonoBehaviour
{

    bool isSelecting = false;

    public int selectStage = 1;

    public CardGroup abilityGroup;
    public CardGroup charGroup;
    public CardGroup EnemyGroup;
    public CardGroup currentGroup;

    public CharacterInfo selectedChar;

    public TurnSystem turnSystem;

    public UIManager manager;

    int charCount;
    int abilityCount;
    int enemyCount;
    int count;
    int maxCount;

    public Card[] characters;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && count <= maxCount && count >= 0)
        {
            count++;
         
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && count <= maxCount && count >= 0)
        {
            count--;
            
        }


       
    }

    void ChangeStage(int targetStage)
    {
        selectStage = targetStage;

        if (selectStage == 1)
        {
            currentGroup = charGroup;
        }

    }
}
