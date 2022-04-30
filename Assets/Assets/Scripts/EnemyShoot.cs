using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject EnemyBullets;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("FireEnemyBullet", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FireEnemyBullet()
    {
        GameObject playerShip = GameObject.Find("Player");

        if (playerShip != null)
        {
            Debug.Log("NOT NULL");
            GameObject bullet = (GameObject)Instantiate(EnemyBullets);

            bullet.transform.position = transform.position;

            Vector2 direction = playerShip.transform.position - bullet.transform.position;

            bullet.GetComponent<EnemyBullets>().SetDirection(direction);


        }
    }
}
