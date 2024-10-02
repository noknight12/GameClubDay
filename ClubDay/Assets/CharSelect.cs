using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{

    public CharacterInfo selectedChar;
    public TurnSystem turnSystem;
    public UIManager manager;
    int charCount;

    public CharacterInfo[] characters;

  
    void Select()
    {
        
        manager.charAbilityMenu.SetActive(true);

    }

    private void Start()
    {
        charCount = 0;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && charCount < characters.Length && charCount >= 0) 
        {
            charCount++;
            selectedChar = characters[charCount];
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) && charCount < characters.Length && charCount >= 0)
             {
            charCount--;
            selectedChar = characters[charCount];
        }
    }
}
