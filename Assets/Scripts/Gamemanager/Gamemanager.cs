using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Gamemanager : MonoBehaviour
{
    [FormerlySerializedAs("Wave")] public int wave = 0;
    private GameObject _spawner;
    private Spawner _spawn;
    void Start()
    {
        _spawner = GameObject.FindGameObjectWithTag("Spawn");
        _spawn = _spawner.GetComponent<Spawner>();

        StartCoroutine(WaveGenerator());
        
    }

    IEnumerator WaveGenerator()
    {
        wave++;
        yield return _spawn.Spawn(5);
        yield return new WaitForSeconds(5);
        StartCoroutine(WaveGenerator());
    }

}
