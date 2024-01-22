using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private Vector2 _direction = new Vector2(0, 0);
    public Tower tower;
    public MobProperties mob;
    private GameObject _player;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        tower = _player.GetComponent<Tower>();
        
        _direction = target.transform.position - transform.position;

        Vector3 look = transform.InverseTransformPoint(target.transform.position);
        float angle = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg-90;
        transform.Rotate(0, 0, angle);
    }

    void Update()
    {
        transform.Translate(tower.attackSpeed * Time.deltaTime * Vector3.up);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        mob = collision.gameObject.GetComponent<MobProperties>();
        if (collision.gameObject == target)
        {
            if(mob.health - tower.attack <= 0)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            } else
            {
                mob.health -= tower.attack;
                Destroy(gameObject);
            }
        }
    }
}