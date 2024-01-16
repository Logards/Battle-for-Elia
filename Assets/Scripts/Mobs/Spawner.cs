using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;

    public GameObject GameManagerObject;
    private Gamemanager gamemanager;

    private int spawnTempo = 5;
    public float radius = 2.5f;
    public float x_center;
    public float y_center;

    public GameObject[] MobTypes;



    private void Start()
    {
        gamemanager = GameManagerObject.GetComponent<Gamemanager>();
    }



    public IEnumerator Spawn(int spawnCount)
    {

        int difficulty = 1;

        if (gamemanager.Wave < 2)
        {
            difficulty = 1;
        }else if (gamemanager.Wave < 5)
        {
            difficulty = 2;
        }else if (gamemanager.Wave < 8)
        {
            difficulty = 3;
        } else
        {
            difficulty = MobTypes.Count();
        }
 


        x_center = transform.position.x;
        y_center = transform.position.y;
        for (int temp = 0; temp < spawnTempo; temp++)
        {
            int spawnN = Random.Range(1, spawnCount);
            spawnCount -= spawnN;

            for (int _ = 0; _ < spawnN; _++)
            {
                Vector2 spawnPos = randomPoint();
                Instantiate(MobTypes[Random.Range(0,difficulty)], spawnPos, Quaternion.identity);

            }
            yield return new WaitForSeconds(2f);
            
            if (spawnCount == 0) {
                break;
            }

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
