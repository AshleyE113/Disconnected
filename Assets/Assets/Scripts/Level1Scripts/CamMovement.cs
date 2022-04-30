using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    //private PlayerMovement player;
    /*
     * Maybe have an invisible object that the camera follows?
     * */
    public float camSpeed;
    public PlayerMovement PM;

    void Start()
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        while (!PM.endGame)
        {
            //distanceToMove = player.transform.position.x;

            Vector2 position = transform.position;

            position = new Vector2(position.x + camSpeed * Time.deltaTime, position.y);

            transform.position = position;

            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            //transform.position += new Vector2(camSpeed * Time.deltaTime, 0f);
            // transform.position = new Vector3(player.transform.position.x + distanceToMove, transform.position.y, transform.position.z);
            //lastPlayerPos = player.transform.position;
        }
    }
}
