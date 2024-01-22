using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MobAttack : MonoBehaviour
{
    private GameObject _target;
    public float attackCooldown = 1f;

    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(AttackCooldown());
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private IEnumerator AttackCooldown()
    {
        Attack();
        yield return new WaitForSeconds(attackCooldown);
        StartCoroutine(AttackCooldown());
    }

    private void Attack()
    {
        Debug.Log("Attack " + _target.name);
    }
}
