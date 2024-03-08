using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher1 : MonoBehaviour
{

    public Camera Camera1;
    public Camera Camera2;

    private Camera currentCamera;
    // Start is called before the first frame update
    void Start()
    {
        currentCamera = Camera1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            

            if (currentCamera == Camera1)
            {
                currentCamera.gameObject.SetActive(false);
                currentCamera = Camera2;

            } else
            {
                currentCamera.gameObject.SetActive(false);
                currentCamera = Camera1;
            }
            currentCamera.gameObject.SetActive(true);
        }
    }
}
