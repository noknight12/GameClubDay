using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffect : MonoBehaviour
{
    public Enemy enemy;
    public CharacterInfo characterInfo;

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
    
    void CharacterStatusRunner(string statusName, Enemy enemy)
    {
        this.enemy = enemy;
        Invoke(statusName, 0);
    }
    void EnemyStatusRunner(string statusName, CharacterInfo characterInfo)
    {
        this.characterInfo = characterInfo;
        Invoke(statusName, 0);
    }
    // Status Effects to Implement:

    // Ranger Statuses:
    // 1. Charge - Ranger's Charge move, treated as a 1-turn status effect.
    // 2. Double Attack - Ranger's Ultimate doubles attack for 2 turns.
    void RangerCharge()
    {
        
    }
    void RangerDoubleAttack()
    {

    }
    // Tank Statuses:
    // 1. Block - Blocks attacks for a turn.
    void TankBlock()
    {

    }
    // 2. Stun - Stun effect applied on enemies by Tank's Bash and Ultimate; minions are stunned for 2 turns, boss for 1 turn.
    void TankStun()
    {

    }
    // 3. Aggro - Required to unlock the Reflect move.
    void TankAggro()
    {

    }
    /* 4. Reflect - Unlocked after a tank aggro followed by a block. deals half dmg reflected back onto enemy and character
    takes no dmg*/
    void TankReflect()
    {

    }

    // Mage Statuses:
    // 1. Heal - Heals for 40% of the character’s HP.
    void MageHeal()
    {

    }
    // 2. Overheal - Up to 20% of HP converts to a shield that lasts for 3 turns or until broken.
    void MageOverheal()
    {

    }
    // 3. Cold - Reduces attack and damage by 20% for 2 turns; freezes minions, causing them to skip a turn.
    void MageCold()
    {

    }
    // 4. Frozen - Minions skip a turn due to this effect.
    void MageFrozen()
    {

    }
    // 5. Dispel - Removes dispellable status effects from heroes or enemies.
    void MageDispel()
    {

    }

    // Boss Statuses:
    // 1. Poison - Target loses 5% HP each turn for 2 turns.
    void BossPoison()
    {

    }
    // 2. Boss Heavy - Applies 50% of the damage to side targets.
    void BossHeavy()
    {

    }
    // 3. Boss Ult - Deals 50% damage on the first turn and the remaining 50% as damage-over-time (DOT) spread over 5 turns.
    void BossUlt()
    {

    }
    // 4. Shock - Lowers defense for 3 turns.
    void BossShock()
    {

    }
    // 5. Boss Shield - Needs 5 hits/instances of damage to break.
    void BossShield()
    {

    }

    // Minion Statuses:
    // 1. Minion's Heavy Attack Charge - Minion performs a heavy attack after 2 normal attacks.
    void MinionHeavyAttackCharge()
    {

    }


}
