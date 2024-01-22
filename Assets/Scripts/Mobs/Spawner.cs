using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;

    [FormerlySerializedAs("GameManagerObject")] public GameObject gameManagerObject;
    private Gamemanager _gamemanager;

    private int _spawnTempo = 5;
    public float radius = 2.5f;
    [FormerlySerializedAs("x_center")] public float xCenter;
    [FormerlySerializedAs("y_center")] public float yCenter;

    [FormerlySerializedAs("MobTypes")] public GameObject[] mobTypes;



    private void Start()
    {
        _gamemanager = gameManagerObject.GetComponent<Gamemanager>();
    }



    public IEnumerator Spawn(int spawnCount)
    {

        int difficulty = 1;

        if (_gamemanager.wave < 2)
        {
            difficulty = 1;
        }else if (_gamemanager.wave < 5)
        {
            difficulty = 2;
        }else if (_gamemanager.wave < 8)
        {
            difficulty = 3;
        } else
        {
            difficulty = mobTypes.Count();
        }
 


        xCenter = transform.position.x;
        yCenter = transform.position.y;
        for (int temp = 0; temp < _spawnTempo; temp++)
        {
            int spawnN = Random.Range(1, spawnCount);
            spawnCount -= spawnN;

            for (int _ = 0; _ < spawnN; _++)
            {
                Vector2 spawnPos = RandomPoint();
                Instantiate(mobTypes[Random.Range(0,difficulty)], spawnPos, Quaternion.identity);

            }
            yield return new WaitForSeconds(2f);
            
            if (spawnCount == 0) {
                break;
            }

        }

    }

    Vector2 RandomPoint()
    {
        float t = 2 * Mathf.PI * Random.Range(0.0f,1.0f);
        float x = (radius + Random.Range(-0.5f,0.5f)) * Mathf.Cos(t) + xCenter;
        float y = (radius + Random.Range(-0.5f, 0.5f)) * Mathf.Sin(t) + yCenter;

        return new Vector2(x, y);
    }
}
