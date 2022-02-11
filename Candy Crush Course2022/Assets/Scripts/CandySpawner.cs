using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] float maxX;
    [SerializeField] GameObject[] candy;

    [SerializeField] bool spawn=true;

    public static CandySpawner instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    void Start()
    {
        InvokeRepeating("SpawnCandy", 5f, 1f);
    }
    
    void SpawnCandy()
    {
        int rand = Random.Range(0, candy.Length);
        float randomX = Random.Range(-maxX, maxX);
        Vector3 pos = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(candy[rand], pos, transform.rotation);
    }

    public void StopSpawnCandy()
    {
        CancelInvoke("SpawnCandy");
    }
}
