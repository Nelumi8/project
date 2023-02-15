using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootprojectiles : MonoBehaviour
{

    public Transform gunendpointposition;
    public GameObject pfbullet;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();

        }
    }

    void shoot()
    {
        Instantiate(pfbullet, gunendpointposition.position, gunendpointposition.rotation);
    }

}