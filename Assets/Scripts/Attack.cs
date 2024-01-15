using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Attack : MonoBehaviour
{
    public GameObject arrow;
    public Tower tower = new Tower();
    private bool isAttack = false;


    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemis")
        {
            StartCoroutine(AttackSpeed());
        }     
    }

    public IEnumerator AttackSpeed()
    {
        if (isAttack)
        {
            yield break;
        }
        isAttack = true;
        Instantiate(arrow, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(tower.attackSpeed);
        isAttack = false;
    }
}