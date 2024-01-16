using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public int Wave = 0;
    private GameObject Spawner;
    private Spawner Spawn;
    void Start()
    {
        Spawner = GameObject.FindGameObjectWithTag("Spawn");
        Spawn = Spawner.GetComponent<Spawner>();

        StartCoroutine(WaveGenerator());
        
    }

    IEnumerator WaveGenerator()
    {
        Wave++;
        yield return Spawn.Spawn(5);
        yield return new WaitForSeconds(5);
        StartCoroutine(WaveGenerator());
    }

}
