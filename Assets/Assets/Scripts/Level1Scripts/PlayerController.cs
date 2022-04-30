using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject bullets; //bullet prefab
    [SerializeField] GameObject bulletPos1; //pos where I want to bullet to spawn from
    [SerializeField] float speed; //player speed
    public int playerLives;
    public bool endGame;

    private CameraShake shake;

    void Start()
    {
        playerLives = 3;
        shake = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<CameraShake>();
        endGame = false;
    }

    void Update()
    {
        //Movement for the player
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;
        Move(direction);

        if (Input.GetKeyDown("space"))
        {
            GameObject bullet1 = Instantiate(bullets);
            bullet1.transform.position = bulletPos1.transform.position;
        }
    }

    void Move(Vector2 direction)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        max.x -= 0.225f;
        min.x += 0.225f;

        max.y -= 0.285f;
        max.y += 0.285f;

        Vector2 pos = transform.position;
        pos += direction * speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        transform.position = pos;
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if ((col.tag == "EnemyShip") || (col.tag == "EnemyBullet"))
        {
            if (playerLives > 0)
            {
                shake.CamShake();
                playerLives -= 1;
            }
            else
            {
                //shake.CamShake();
                //Destroy(gameObject);
            }

        }

        if (col.tag == "Endpoint")
        {
            speed = 0f;
            endGame = true;
        }
    }
}
