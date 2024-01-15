using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Properties : MonoBehaviour
{
    public float speed = 0.5f;
    public float health = 10f;
    public float damage = 0.5f;
    public float range = 1f;
    public int goldsLoot = 1;

    // Start is called before the first frame update
    void Start()
    {
        speed = (speed - Random.Range(0f, 0.2f)) / 10;
        goldsLoot = Random.Range(1, 5);
    }

    private void OnDestroy()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Properties>().golds += goldsLoot;
    }
}
