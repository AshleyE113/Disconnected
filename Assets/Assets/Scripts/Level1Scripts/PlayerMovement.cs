using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bullets; //bullet prefab
    public GameObject bulletPos1;
    public float speed;
    public int playerLives;
    public bool endGame;

    private CameraShake shake;
    //public bool hitByEnemy;

    //public GameObject playerExplosion;
    // Start is called before the first frame update
    void Start()
    {

        playerLives = 3;
        shake = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<CameraShake>();
        //hitByEnemy = false;
        endGame = false;

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Pressing down");
            Vector2 pos = transform.position;
            pos.x-=speed;
            transform.position = pos;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Pressing down2");
            Vector2 pos = transform.position;
            pos.x += speed;
            transform.position = pos;

        }
       
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Pressing down3");
            Vector2 pos = transform.position;
            pos.y += speed;
            transform.position = pos;
        }
       
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Pressing down4");
            Vector2 pos = transform.position;
            pos.y -= speed;
            transform.position = pos;

        } */

        //fire bullets when spacebar is hit
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet1 = (GameObject)Instantiate(bullets);
            bullet1.transform.position = bulletPos1.transform.position;
        }

       // /*
       float x = Input.GetAxisRaw("Horizontal");
       float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        Move(direction);
        //*/
    }

    void Move(Vector2 direction)
    {

        //Debug.Log("In the move func");
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        max.x = max.x - 0.225f;
        min.x = min.x + 0.225f;

        max.y = max.y - 0.285f;
        max.y = max.y + 0.285f;

        Vector2 pos = transform.position;
        pos += direction * speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        transform.position = pos;
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
       // Debug.Log("Lives: " + playerLives);
        if ((col.tag == "EnemyShip") || (col.tag == "EnemyBullet"))
        {
            if (playerLives > 0)
            {
                shake.CamShake();
                playerLives -= 1;
            }
            else
            {
                shake.CamShake();
                Destroy(gameObject);
            }
            
        }

        if (col.tag == "Endpoint")
        {
            speed = 0f;
            endGame = true;
        }
    }
}
