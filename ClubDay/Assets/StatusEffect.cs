using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffect : MonoBehaviour
{

    //it shouldnt be an intereger
   
   
    //target of status
    //
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void statusManager(int targetchars)
    {
        
    }
    
    void StatusRunner(string statusName)
    {
        Invoke(statusName, 2.0f);
    }
    // Status Effects to Implement:

    // Ranger Statuses:
    // 1. Charge - Ranger's Charge move, treated as a 1-turn status effect.
    // 2. Double Attack - Ranger's Ultimate doubles attack for 2 turns.
    void RangerChange()
    {

    }
    void RangerDoubleAttack()
    {

    }
    // Tank Statuses:
    // 1. Block - Blocks attacks for a turn.
    // 2. Stun - Stun effect applied on enemies by Tank's Bash and Ultimate; minions are stunned for 2 turns, boss for 1 turn.
    // 3. Aggro - Required to unlock the Reflect move.

    // Mage Statuses:
    // 1. Heal - Heals for 40% of the character’s HP.
    // 2. Overheal - Up to 20% of HP converts to a shield that lasts for 3 turns or until broken.
    // 3. Cold - Reduces attack and damage by 20% for 2 turns; freezes minions, causing them to skip a turn.
    // 4. Frozen - Minions skip a turn due to this effect.
    // 5. Dispel - Removes dispellable status effects from heroes or enemies.

    // Boss Statuses:
    // 1. Poison - Target loses 5% HP each turn for 2 turns.
    // 2. Boss Heavy - Applies 50% of the damage to side targets.
    // 3. Boss Ult - Deals 50% damage on the first turn and the remaining 50% as damage-over-time (DOT) spread over 5 turns.
    // 4. Shock - Lowers defense for 3 turns.
    // 5. Boss Shield - Needs 5 hits/instances of damage to break.

    // Minion Statuses:
    // 1. Minion's Heavy Attack Charge - Minion performs a heavy attack after 2 normal attacks.




}
