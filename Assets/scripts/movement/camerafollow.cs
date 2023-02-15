using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // camera follow

    private Vector3 camerafollowposition;

    public void Setup(Vector3 camerafollowposition)
    {
        this.camerafollowposition = camerafollowposition;
    }

    void Update()
    {
        //Vector3 camerafollowposition = new Vector3(0, 100);
        camerafollowposition.z = transform.position.z;
        transform.position = camerafollowposition;
    }
}
