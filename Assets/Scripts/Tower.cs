using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class Tower : MonoBehaviour
{

    public float attack = 1f;
    public float attackSpeed = 1.5f;
    public float attackRange = 1f;
    public float defense = 0f; public float gainGold = 1f;
    public float gold = 0f;
    public TMP_Text goldCount;

    private void Update()
    {
        
        goldCount.SetText(gold.ToString());
    }
}
