using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript2 : MonoBehaviour
{
    float TimeCounter = 0;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter += Time.deltaTime;
        float x = 5.1f + -Mathf.Cos(TimeCounter);//-4.52;
        float y = -2.05f + -Mathf.Sin(TimeCounter);//2.58;
        float z = 0;//0;
        transform.position = new Vector3(x, y, z);
        transform.Rotate(new Vector3(0, 0, -rotationSpeed) * Time.deltaTime);
    }
}
