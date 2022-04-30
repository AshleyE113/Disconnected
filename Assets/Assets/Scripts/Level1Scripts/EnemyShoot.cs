using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject EnemyBullets;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("FireBullets", 2f);
    }

    void FireBullets()
    {
        GameObject playerShip = GameObject.Find("Player");

        if (playerShip != null)
        {
            Debug.Log("NOT NULL");
            GameObject bullet = Instantiate(EnemyBullets);

            bullet.transform.position = transform.position;

            Vector2 direction = playerShip.transform.position - bullet.transform.position;

            bullet.GetComponent<EnemyBullets>().SetDirection(direction);


        }
    }
}
