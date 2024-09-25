using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{

   public CharacterInfo characterInfo;
   public TurnSystem turnSystem;
   public UIManager manager;
   

  
    void Select()
    {
        turnSystem.currentCharacter = characterInfo;
        manager.charAbilityMenu.SetActive(true);

    }
}
