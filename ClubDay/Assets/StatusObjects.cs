using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusObjects: MonoBehaviour
{
    int priority;
    int tick;
    string statusName;
    bool isDispellable;
    StatusEffect statusEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public StatusObjects(int priority, int tick, string statusName, StatusEffect statusEffect, bool isDispellable)
    {
        this.priority = priority;
        this.tick = tick;
        this.statusName = statusName;
        this.statusEffect = statusEffect;
        this.isDispellable = isDispellable;
    }
    public void RunStatusEffect(StatusEffect statusEffect)
    {

    }



}
