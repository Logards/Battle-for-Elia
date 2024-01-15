using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Mob_Movement : MonoBehaviour
{
    private GameObject target;
    public float speed = 1f;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((target.transform.position - transform.position) * Time.deltaTime * speed);
    }
}
