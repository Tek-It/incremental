using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public GameObject[] EnemyPrefab;
    
    

    [SerializeField]
    public float MinimumSpawnTime;

    [SerializeField]
    public float MaximumSpawnTime;

    [SerializeField]
    public float TimeUntilSpawn;




    void Start()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilSpawn -= Time.deltaTime;
        if (TimeUntilSpawn <= 0)
        {
            int randomEnemy = Random.Range(0, EnemyPrefab.Length);
            Instantiate(EnemyPrefab[randomEnemy], transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        TimeUntilSpawn = Random.Range(MinimumSpawnTime, MaximumSpawnTime);
    }
}
