using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    public float _minimumSpawnTime;

    [SerializeField]
    public float _maximumSpawnTime;

    [SerializeField]
    public float _timeUntilSpawn;




    void Start()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;
        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
