using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;
    private float targetX = 0;
    private float targetY = 0;
    private Vector2 direction = new Vector2(0, 0);
    public Tower tower;
    public Mob_Properties mob;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemis");
        targetX = target.transform.position.x;
        targetY = target.transform.position.y;
        direction = target.transform.position - transform.position;
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * tower.attackSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        mob = collision.gameObject.GetComponent<Mob_Properties>();
        if (collision.gameObject.tag == "Enemis")
        {
            if(mob.health - 1 <= 0)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            } else
            {
                mob.health -= 1;
                Destroy(gameObject);
            }
        }
    }
}
