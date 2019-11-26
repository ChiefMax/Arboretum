using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimal : MonoBehaviour
{
    float timeSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSpeed += Time.deltaTime;

        float x = Mathf.Cos(timeSpeed);
        float y = Mathf.Sin(timeSpeed);
        float z = 0;

        transform.position = new Vector3(x,y,z);
    }
}
