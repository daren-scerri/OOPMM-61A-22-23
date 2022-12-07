using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner _instance;

    public List<EnemySO> enemySOList;


    //SINGLETON PATTERN
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }
    }



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
            GameObject enemyInstance = Instantiate(enemySOList[enemychoice].enemyGO, new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0), Quaternion.identity);
            enemyInstance.GetComponent<Enemy>().startHealth = enemySOList[enemychoice].strength;
            enemyInstance.GetComponent<Enemy>().scorevalue = enemySOList[enemychoice].scorevalue;
            yield return new WaitForSeconds(1);
        }
    }
}
