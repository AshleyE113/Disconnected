using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    //private PlayerMovement player;
    /*
     * Maybe have an invisible object that the camera follows?
     * */
    [SerializeField] float camSpeed;
    [SerializeField] PlayerController PC;

    void Update()
    {
        while (!PC.endGame)
        {
            Vector2 position = transform.position;

            position = new Vector2(position.x + camSpeed * Time.deltaTime, position.y);

            transform.position = position;

            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        }
    }
}
