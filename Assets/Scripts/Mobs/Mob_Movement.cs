using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour
{
    private GameObject _target;
    private Vector3 _direction;

    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _direction = (_target.transform.position - transform.position);
        Vector3 look = transform.InverseTransformPoint(_target.transform.position);
        float angle = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg + 90;
        transform.Rotate(0,0,angle);
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Translate(gameObject.GetComponent<Mob_Properties>().speed * Time.deltaTime * direction);
        transform.Translate(gameObject.GetComponent<MobProperties>().speed * Time.deltaTime * Vector3.down);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            _direction = new Vector3(0, 0, 0);
            Destroy(gameObject);
        }
    }
}
