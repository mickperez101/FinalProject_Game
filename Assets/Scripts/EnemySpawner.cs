using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
    public List<GameObject> Enemies = new List<GameObject>();
    public float SpawnRate;

    private float x, y;
    private Vector3 spawnPos;

    // Start is called before the first frame update

    
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        x = Random.Range(-3, 6);
        y = Random.Range(-5, 11);
        spawnPos.x += x;
        spawnPos.y += y;

        //Spawn Enemies
        
        Instantiate(Enemies[0],spawnPos,Quaternion.identity);

        yield return new WaitForSeconds(SpawnRate);
        StartCoroutine(SpawnEnemy());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
