using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Properties : MonoBehaviour
{
    public float speed = 0.5f;
    public float health = 0.5f;
    public float damage = 0.5f;
    public float range = 1f;

    // Start is called before the first frame update
    void Start()
    {
        speed -= Random.Range(0f, 0.2f);
        speed = speed / 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
