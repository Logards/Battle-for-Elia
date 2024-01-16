using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Movement : MonoBehaviour
{
    private GameObject target;
    private Vector3 direction;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        direction = (target.transform.position - transform.position);
        Vector3 Look = transform.InverseTransformPoint(target.transform.position);
        float angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg + 90;
        transform.Rotate(0,0,angle);
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.Translate(gameObject.GetComponent<Mob_Properties>().speed * Time.deltaTime * direction);
        transform.Translate(gameObject.GetComponent<Mob_Properties>().speed * Time.deltaTime * Vector3.down);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            direction = new Vector3(0, 0, 0);
            Destroy(gameObject);
        }
    }
}
