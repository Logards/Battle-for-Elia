using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Movement : MonoBehaviour
{
    private GameObject target;
    public float speed = 0.2f;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(target.transform.position * Time.deltaTime * speed);
    }
}
