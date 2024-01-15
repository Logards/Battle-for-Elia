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
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(gameObject.GetComponent<Mob_Properties>().speed * Time.deltaTime * direction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            direction = new Vector3(0, 0, 0);
            Destroy(gameObject);
        }
    }
}
