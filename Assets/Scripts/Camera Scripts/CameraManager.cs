using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera ActiveCamera = null;

    public static bool IsActiveCamera(CinemachineVirtualCamera cam) //returns whether camera is active or not
    {
        return cam == ActiveCamera; 
    }

    public static void SwitchCamera(CinemachineVirtualCamera newCam) //allows cameras to switch via Priority 
    { 
        newCam.Priority = 10;
        ActiveCamera = newCam;

        foreach (CinemachineVirtualCamera cam in cameras)
        {
            if(cam != newCam)
            {
                cam.Priority = 0;
            }
        }
    } 


    public static void Register(CinemachineVirtualCamera cam) //add camera
    {
        cameras.Add(cam);
    }

    public static void Unregister(CinemachineVirtualCamera cam) //remove camera
    {
        cameras.Remove(cam);
    }
}
