using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{

    public GameObject Meteor; //enemy prefab
    public float maxSpawnRateInSeconds = 5f;
    public GameObject Player;
    public PlayerMovement PM;
    public GameObject Endpoint;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnEnemy", maxSpawnRateInSeconds);
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    void spawnEnemy()
    {


        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject anEnemy = (GameObject)Instantiate(Meteor);
        anEnemy.transform.position = new Vector2(max.x, Random.Range(min.y, max.y));
        NextEnemySpawn();

    }

    void NextEnemySpawn()
    {
        //while (!PM..endGame)//!(Player.transform.position.x + 25 >= Endpoint.transform.position.x - 10)) // || !(PM..endGame)
        //{
       // Debug.Log("In the while");
        float SpawnInNSeconds;

        if (maxSpawnRateInSeconds > 20f)
        {
            SpawnInNSeconds = Random.Range(20f, maxSpawnRateInSeconds);
            Debug.Log("Spawning!");
        }
        else
            SpawnInNSeconds = 10f;

        Invoke("spawnEnemy", SpawnInNSeconds);
        //}
    }

    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 20f)
            maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 20f)
            CancelInvoke("IncreaseSpawnRate");
    }
}
