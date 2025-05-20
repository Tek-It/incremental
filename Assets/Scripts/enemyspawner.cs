using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] EnemyPrefab;
    public int Counter = 0;
    
    

    public float MinimumSpawnTime;

    
    public float MaximumSpawnTime;

    
    public float TimeUntilSpawn;
    public GameObject enemy2;

    void Start()
    {
        SetTimeUntilSpawn();
        if (PlayerPrefs.GetInt("Triangles",0) != 0)
        {
            Counter = Counter + 2;
            Debug.Log(Counter);
        }
        if (PlayerPrefs.GetInt("Hexagons", 0) != 0)
        {
            Counter = Counter + 1;
            Debug.Log(Counter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimeUntilSpawn -= Time.deltaTime;
        if (TimeUntilSpawn <= 0)
        {
            Instantiate(EnemyPrefab[Random.Range(0, Counter)], transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        TimeUntilSpawn = Random.Range(MinimumSpawnTime, MaximumSpawnTime);
    }
}
