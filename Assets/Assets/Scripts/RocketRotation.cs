using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRotation : MonoBehaviour
{
    // Start is called before the first frame update
    float TimeCounter = 0f;
    public float rotationSpeed;
    public float x_change = 1f;
    public float y_change = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x_change += 0.01f;
        y_change-= 0.01f;
        TimeCounter += Time.deltaTime;
        float x = 3.38f - Mathf.Cos(TimeCounter);
        float y = 3.364f - Mathf.Sin(TimeCounter);
        float z = 0;//0;
        transform.position = new Vector3(x - x_change, y + y_change, z);
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
}
