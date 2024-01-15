using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Mob_Movement : MonoBehaviour
{
    private GameObject target;
    private float speed;
    private Vector3 direction;

    void Start()
    {
        speed = GetComponent<Mob_Properties>().speed;
        target = GameObject.FindGameObjectWithTag("Player");
        direction = (target.transform.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            direction = new Vector3(0, 0, 0);
        }
    }
}
