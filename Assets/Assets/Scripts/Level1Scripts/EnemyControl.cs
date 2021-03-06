using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] float speed;

    private CameraShake shake;

    void Start()
    {
        speed = 2f;
        shake = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<CameraShake>();
    }

    void Update()
    {
        Vector2 position = transform.position;
        position = new Vector2(position.x - speed * Time.deltaTime, position.y);
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        //Destroys enemy if it's outside the screen
        if (transform.position.x < min.x)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ( (col.tag == "PlayerBullet"))
        {
            shake.CamShake();
            Destroy(gameObject);
        }
    }
}
