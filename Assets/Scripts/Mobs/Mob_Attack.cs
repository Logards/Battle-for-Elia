using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Mob_Attack : MonoBehaviour
{
    private GameObject target;
    public float attackCooldown = 1f;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(AttackCooldown());
        }
    }

    private IEnumerator AttackCooldown()
    {
        Attack();
        yield return new WaitForSeconds(attackCooldown);
        StartCoroutine(AttackCooldown());
    }

    private void Attack()
    {
        Debug.Log("Attack " + target.name);
    }
}
