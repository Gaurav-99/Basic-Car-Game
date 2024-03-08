using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesVehicles : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
