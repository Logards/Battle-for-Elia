using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private Vector2 direction = new Vector2(0, 0);
    public Tower tower;
    public Mob_Properties mob;

    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Enemis");
        direction = target.transform.position - transform.position;

        Vector3 Look = transform.InverseTransformPoint(target.transform.position);
        float angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg-90;
        transform.Rotate(0, 0, angle);
    }

    void Update()
    {
        //transform.Translate(direction * Time.deltaTime * tower.attackSpeed);
        transform.Translate(tower.attackSpeed * Time.deltaTime * Vector3.up);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        mob = collision.gameObject.GetComponent<Mob_Properties>();
        if (collision.gameObject == target)
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
