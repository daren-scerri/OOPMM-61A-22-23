using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyScriptableObject", order = 1)]

public class EnemySO : ScriptableObject
{

    public GameObject enemyGO;
    public int scorevalue, strength;
    public float speed;
}
