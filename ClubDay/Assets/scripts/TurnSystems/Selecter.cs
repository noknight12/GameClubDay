using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Selecter : MonoBehaviour
{
    

    public Abilities abilities;

    public Animator animator;

    public int selectStage = 1;

    public CardGroup abilityGroup;
    public CardGroup charGroup;
    public CardGroup enemyGroup;
    public CardGroup currentGroup;

    public TurnSystem turnSystem;

    public UIManager manager;


    CharacterInfo selectedChar;
    string selectedAbility;
    Enemy target;


    //int charCount;
    //int abilityCount;
    //int enemyCount;

    int count;
    int maxCount;


    Card selectedCard;



    public List<Card> cards;

    bool mageUsed;
    bool tankUsed;
    bool rangeUsed;

    // Start is called before the first frame update
    void Start()
    {
        currentGroup = charGroup;
        maxCount = currentGroup.cards.Count;
        cards = currentGroup.cards;
    }

    // Update is called once per frame
    void Update()
    {
        if (turnSystem.isPlayerTurn)
        {
            //arrow keys through the cards
            if (Input.GetKeyDown(KeyCode.RightArrow) && count < maxCount - 1 && count >= 0)
            {

                count++;
                Debug.Log(count);

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && count < maxCount && count > 0)
            {
                count--;
                Debug.Log(count);
            }


            // Card Selected
            if (Input.GetKeyDown(KeyCode.Return))
            {

                SelectCard();
                ChangeStage(selectStage + 1);

            }

        }
    }


    void SelectCard()
    {
        selectedCard = cards[count]; // simply sets the card selected to be the current card we are at rn
        if (selectStage == 1)
        {
            selectedChar = selectedCard.characterInfo;
            if (selectedChar.isMage)
            {
                mageUsed = true;
            }
            else if (selectedChar.isTank)
            {
                tankUsed = true;
            }
            else if (selectedChar.isRange)
            {
                rangeUsed = true;
            }
            cards.Remove(selectedCard);
            
           
        }
        if(selectStage == 2)
        {
            selectedAbility = selectedCard.abilityName;
        }
        if( selectStage == 3)
        {
            if(selectedCard.bossAI == null)
            {
                target = selectedCard.minion;
            }
        }
        Debug.Log(selectedCard);
    }


    // picks if the curent stage is a character card, abililty or a enemy
    void ChangeStage(int targetStage)
    {
        selectStage = targetStage;
        if (selectStage == 1)
        {
            //select char
            currentGroup = charGroup;

            charGroup.gameObject.SetActive(true);
            abilityGroup.gameObject.SetActive(false);
            enemyGroup.gameObject.SetActive(false);
            maxCount = currentGroup.cards.Count;
            cards = currentGroup.cards;
        }

        else if (selectStage == 2)
        {
            //select abiilty
           
            

            abilityGroup = selectedChar.abilityCards;
            currentGroup = abilityGroup;
            abilityGroup.gameObject.SetActive(true);
            charGroup.gameObject.SetActive(false);
            enemyGroup.gameObject.SetActive(false);
            maxCount = currentGroup.cards.Count;
            cards = currentGroup.cards;
            Debug.Log("Now selecting abilities.");


        }
        else if (selectStage == 3)
        {
            //select target
            currentGroup = enemyGroup;
            enemyGroup.gameObject.SetActive(true);
            abilityGroup.gameObject.SetActive(false);
            charGroup.gameObject.SetActive(false) ;
            maxCount = currentGroup.cards.Count;
            cards = currentGroup.cards;
            Debug.Log("Now selecting enemies.");
        }
        else
        {
            //do action
          //  abilities.RunCharAbility(selectedAbility, target, selectedChar);
            if (mageUsed && tankUsed && rangeUsed)
            {
                turnSystem.isPlayerTurn = false;
            }
            else
            {
                ChangeStage(1);
            }
           
            
        }
        count = 0;
    }
}
    //figure out to scroll throuhg abiilties list

