using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    string statusEffect;
    public int Dmg_Taken;
    public int HP;
    public int Defence;
    public int AtkMulti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void TakeHit()
    {
        HP -= Dmg_Taken;
    }
  
}
