using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Gamemanager : MonoBehaviour
{
    public int wave = 0;
    private GameObject _spawner;
    private Spawner _spawn;
    void Start()
    {
        _spawner = GameObject.FindGameObjectWithTag("Spawn");
        Debug.Log(_spawner);
        _spawn = _spawner.GetComponent<Spawner>();
        Debug.Log(_spawn);

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
