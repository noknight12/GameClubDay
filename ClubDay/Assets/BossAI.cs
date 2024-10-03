using System;

using System.Collections.Generic;

using UnityEngine;

public class BossAI : Enemy
{
    public int HP_Boss;
    public int Defence_Boss;
    public int AtkMulti_Boss;
    public string[] randomString;
    // Start is called before the first frame update
    void Start()
    {
        
        HP_Boss = HP; 
        Defence_Boss = Defence;
        AtkMulti_Boss = AtkMulti;
        Boss_Think();
    }
    void Boss_Think()
    {
        ChooseRandomChar();
    }
    void ChooseRandomChar()
    {
        if (randomString.Length == 0)
        {
            Debug.LogError("No strings assigned!");
            return;
        }

        int randomIndex = UnityEngine.Random.Range(0, randomString.Length);  
        string selectedString = randomString[randomIndex];

        // Display the selected string in the console
        Debug.Log("Random String Selected: " + selectedString);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChooseRandomChar();
        }
    }
}
