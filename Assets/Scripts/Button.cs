using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public Tower tower;
    public int attackGold = 10, attackSpeedGold = 10, attackRangeGold = 10, healthGold = 10;
    public TMP_Text attackGoldT, attackNext, attackCurrent, attackSpeedGoldT, attackSpeedNext, attackSpeedCurrent, attackRangeGoldT, attackRangeNext, attackRangeCurrent, healthGoldT, healthNext, healthCurrent;

    private void Start()
    {
        attackGoldT.SetText(attackGold.ToString());
        attackSpeedGoldT.SetText(attackSpeedGold.ToString());
        attackRangeGoldT.SetText(attackRangeGold.ToString());
        healthGoldT.SetText(healthGold.ToString());
    }

    public void AddAttack()
    {
        if (tower.gold >= attackGold)
        {
            tower.attack *= 1.10f;
            tower.gold -= attackGold;
            attackGold += 10;
            attackGoldT.SetText(attackGold.ToString());
            attackNext.SetText((tower.attack * 1.10f).ToString());
            attackCurrent.SetText(tower.attack.ToString());
            
            Debug.Log("Attack added");
        } else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void AddAttackSpeed()
    {
        if (tower.gold >= attackSpeedGold)
        {
            tower.attackSpeed *= 0.95f ;
            tower.gold -= attackSpeedGold;
            attackSpeedGold += 10;
            attackSpeedGoldT.SetText(attackSpeedGold.ToString());
            attackSpeedNext.SetText((tower.attackSpeed + 1).ToString());
            attackSpeedCurrent.SetText(tower.attackSpeed.ToString());
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void AddAttackRange()
    {
        if (tower.gold >= attackRangeGold)
        {
            tower.attackRange += 1;
            tower.gold -= attackRangeGold;
            attackRangeGold += 10;
            attackRangeGoldT.SetText(attackRangeGold.ToString());
            attackRangeNext.SetText((tower.attackRange + 1).ToString());
            attackRangeCurrent.SetText(tower.attackRange.ToString());
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void AddHealth()
    {
        if (tower.gold >= healthGold)
        {
            tower.defense += 1;
            tower.gold -= healthGold;
            healthGold += 10;
            healthGoldT.SetText(healthGold.ToString());
            healthNext.SetText((tower.defense + 1).ToString());
            healthCurrent.SetText(tower.defense.ToString());
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }
}