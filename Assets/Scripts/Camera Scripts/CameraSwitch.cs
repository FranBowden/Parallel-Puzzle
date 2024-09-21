using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    public Transform p1;
    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;

    // Update is called once per frame

    public float xpos = 25;
    void Update()
    {

        if (p1.position.x < xpos)
        {
            CameraManager.SwitchCamera(cam1);
        }

        if (p1.position.x > xpos)
        {
            CameraManager.SwitchCamera(cam2);
           
        }
      

    }
}
