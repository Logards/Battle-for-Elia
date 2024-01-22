using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerProperties : MonoBehaviour
{

    public int golds = 0;
    public TMP_Text goldCount;


    void Start()
    {
        
    }

    void Update()
    {
        goldCount.SetText(golds.ToString());
    }
}
