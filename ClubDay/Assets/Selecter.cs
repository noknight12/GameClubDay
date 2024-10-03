using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Selecter : MonoBehaviour
{

    public Animator animator;

    public int selectStage = 1;

    public CardGroup abilityGroup;
    public CardGroup charGroup;
    public CardGroup enemyGroup;
    public CardGroup currentGroup;

    public TurnSystem turnSystem;

    public UIManager manager;

    //disfunction delete character card karl said so
    CharacterCard selectedCharacter;

    //int charCount;
    //int abilityCount;
    //int enemyCount;

    int count;
    int maxCount;


    Card selectedCard;


    public Card[] cards;

    // Start is called before the first frame update
    void Start()
    {
        currentGroup = charGroup;
        maxCount = currentGroup.cards.Length;
        cards = currentGroup.cards;
    }

    // Update is called once per frame
    void Update()
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


    void SelectCard()
    {
        selectedCard = cards[count]; // simply sets the card selected to be the current card we are at rn
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

            abilityGroup.enabled = false;
            enemyGroup.enabled = false;
            maxCount = currentGroup.cards.Length;
            cards = currentGroup.cards;
        }

        else if (selectStage == 2)
        {
            //select abiilty
            selectedCard = selectedCharacter;
            Debug.Log(selectedCharacter);

            abilityGroup = selectedCharacter.Character.abilityCards;
            currentGroup = abilityGroup;
            charGroup.enabled = false;
            enemyGroup.enabled = false;
            maxCount = currentGroup.cards.Length;
            cards = currentGroup.cards;
            Debug.Log("Now selecting abilities.");


        }
        else if (selectStage == 3)
        {
            //select target
            currentGroup = enemyGroup;
            abilityGroup.enabled = false;
            charGroup.enabled = false;
            maxCount = currentGroup.cards.Length;
            cards = currentGroup.cards;
            Debug.Log("Now selecting enemies.");
        }
        else
        {
            Debug.LogError("wuh oh");
        }
        count = 0;
    }
}
    //figure out to scroll throuhg abiilties list

