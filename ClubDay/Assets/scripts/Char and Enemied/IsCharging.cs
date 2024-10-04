using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCharging : MonoBehaviour
{


    bool isCharging;
    int chargeDuration;
    public Selecter selecter;
    public TurnSystem turnSystem;

    int currentTurn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (turnSystem.numOfTurns > currentTurn)
        {
           currentTurn = turnSystem.numOfTurns;

        }
    }

    public IsCharging(bool isCharging, int chargeDuratino)
    {
        this.isCharging = isCharging;
        this.chargeDuration = chargeDuration;
    }
}
