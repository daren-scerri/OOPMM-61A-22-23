using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<EnemySO> enemySOList;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }



    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int enemychoice = Random.Range(0, enemySOList.Count);
            Instantiate(enemySOList[enemychoice].enemyGO, new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
