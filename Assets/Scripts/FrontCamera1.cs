using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCamera1 : MonoBehaviour
{
    
    public GameObject player;
    private Vector3 offset = new Vector3(5.4f, 2, -5);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
