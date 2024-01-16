using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Attack : MonoBehaviour
{
    public GameObject arrow;
    public Tower tower = new Tower();
    private bool isAttack = false;

    private void Start()
    {

    }


    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemis")
        {
            StartCoroutine(AttackSpeed(collision.gameObject));
        }     
    }

    public IEnumerator AttackSpeed(GameObject target)
    {
        if (isAttack)
        {
            yield break;
        }
        isAttack = true;
        GameObject currentArrow = Instantiate(arrow, transform.position, Quaternion.identity);
        currentArrow.GetComponent<Arrow>().target = target;
        yield return new WaitForSeconds(tower.attackSpeed);
        isAttack = false;
    }
}