using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;

    private float targetX = 0;
    private float targetY = 0;
    private Vector2 direction = new Vector2(0, 0);

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemis");
        targetX = target.transform.position.x;
        targetY = target.transform.position.y;

        direction = target.transform.position - transform.position;
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * 1);
    }
}
