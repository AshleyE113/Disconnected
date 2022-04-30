using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{

    [SerializeField] float speed;
    Vector2 _direction;
    bool isReady;

    void Awake()
    {
        speed = 5f;
        isReady = false;
    }

    void Update()
    {
        if (isReady) //Fires the bullet in the player's direction
        {
            Vector2 position = transform.position;
            position += _direction * speed * Time.deltaTime;

            transform.position = position;

            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            //destroys the bullet once it's off screen
            if ((transform.position.x < min.x) || (transform.position.x > max.x) ||
            (transform.position.y < min.y) || (transform.position.y > max.y))
            {
                Destroy(gameObject);
            }
        }
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;
        isReady = true;
    }

    void OnTriggerEnter2D(Collider2D col) //Destroys GO on collison
    {
        if ((col.tag == "PlayerBullet") || (col.tag == "Player"))
        {
            Destroy(gameObject);
        }
    }

}
