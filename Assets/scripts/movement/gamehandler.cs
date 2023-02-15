using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamehandler : MonoBehaviour
{
    public camerafollow camerafollow;

    private void Start()
    {
        camerafollow.Setup(new Vector3(0, -100));
    }

    
}
