using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Tower tower;
    public int attackGold = 10, attackSpeedGold = 10, attackRangeGold = 10, defenseGold = 10;

    // Start is called before the first frame update
    public void AddAttack()
    {
        if (tower.Gold >= attackGold)
        {
            tower.attack += 1;
            tower.Gold -= 10;
            attackGold += 10;
        } else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void AddAttackSpeed()
    {
        if (tower.Gold >= attackSpeedGold)
        {
            tower.attackSpeed += 1;
            tower.Gold -= 10;
            attackSpeedGold += 10;
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void AddAttackRange()
    {
        if (tower.Gold >= attackRangeGold)
        {
            tower.attackRange += 1;
            tower.Gold -= 10;
            attackRangeGold += 10;
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }

    public void AddDefense()
    {
        if (tower.Gold >= defenseGold)
        {
            tower.Defense += 1;
            tower.Gold -= 10;
            defenseGold += 10;
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }


}
