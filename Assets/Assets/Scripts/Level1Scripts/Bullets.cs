using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    private CameraShake shake;
    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
        //CameraShake = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<CameraShake>();

    }

    // Update is called once per frame
    void Update()
    {
        //Get the current pos
        Vector2 position = transform.position;

        //Compute new bullet pos
        position = new Vector2(position.x + speed * Time.deltaTime, position.y);

        //updates bullets pos
        transform.position = position;
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //Destroys bullet if it's outside the screen
        if (transform.position.x > max.x)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.tag == "EnemyShip") || (col.tag == "EnemyBullet"))
        {
            //For quick testing
            Destroy(gameObject);
        }
    }
}
