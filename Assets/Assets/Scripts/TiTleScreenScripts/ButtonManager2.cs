using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    // public void ButtonMoveScene(string level)
    // {
    //     SceneManager.LoadScene(level, LoadSceneMode.Single);
    //     Debug.Log("Pressed");
    // }

    void Update()
    {
        //Detect if the left mouse button is pressed
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Mouse 0 ");
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }

    //void OnMouseDown()
    //{
    //    Debug.Log("Pressed");
    //    SceneManager.LoadScene("Level1");
    //}
}
