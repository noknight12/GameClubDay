using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCharging : MonoBehaviour
{


    bool isCharging;
    int chargeDuration;
    public Selecter selecter;
    public TurnSystem turnSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (TurnSystem.numOfTurns > currentTurn)
        {
            heavyAttackCD--;

        }
    }

    public IsCharging(bool isCharging, int chargeDuratino)
    {
        this.isCharging = isCharging;
        this.chargeDuration = chargeDuration;
    }
}
