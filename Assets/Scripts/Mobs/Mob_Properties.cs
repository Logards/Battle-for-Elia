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
    public string type = "base";

    void Start()
    {

        float a = type == "runner" ? Random.Range(0.2f,1f) : 0.2f;

        speed = (speed + Random.Range(0f, (type == "runner" ? Random.Range(0.2f, 1f) : 0.2f))) / 10;
        health = (health + Random.Range(0f, (type == "tank" ? Random.Range(0.2f, 1f) : 0.2f))) / 10;
        damage = (damage + Random.Range(0f, (type == "tank" || type == "base" ? Random.Range(0.2f, 0.5f) : 0.2f))) / 10;
        goldsLoot = Random.Range(1, 5);
    }

    private void OnDestroy()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Properties>().golds += goldsLoot;
    }
}
