using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Spawner : MonoBehaviour
{

    public int spawnCount = 5;
    public GameObject toSpawn;
    public float radius = 2.5f;
    public float x_center;
    public float y_center;

    void Start()
    {
        x_center = transform.position.x;
        y_center = transform.position.y;
        for (int i = 0; i < spawnCount; i++)
        {
            Vector2 spawnPos = randomPoint();
            Instantiate(toSpawn, spawnPos, Quaternion.identity);
            
        }
    }

    Vector2 randomPoint()
    {
        float t = 2 * Mathf.PI * Random.Range(0.0f,1.0f);
        float x = (radius + Random.Range(-0.5f,0.5f)) * Mathf.Cos(t) + x_center;
        float y = (radius + Random.Range(-0.5f, 0.5f)) * Mathf.Sin(t) + y_center;

        return new Vector2(x, y);
    }
}
