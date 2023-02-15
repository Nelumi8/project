using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimWeapon : MonoBehaviour
{

    

    public event EventHandler<onshootEventArgs> onshoot;
    public class onshootEventArgs : EventArgs
    {
        public Vector3 gunendpointposition;
        public Vector3 shootposition;
    }

    private Transform aimTransform;
    private Transform aimgunendpointtransform;
    public Animator aimAnimator;

    private void Awake()
    {
        aimTransform = transform.Find("gun");
        aimAnimator = aimTransform.GetComponent<Animator>();
        aimgunendpointtransform = aimTransform.Find("gunendpointposition");
    }

    // Get Mouse Position in World with Z = 0f
    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }
    public static Vector3 GetMouseWorldPositionWithZ()
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    }
    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    }
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }



    private void Update()
    {
        aiming();
        shooting();
    }

    private void aiming()
    {
        Vector3 mousePosition = GetMouseWorldPosition();

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
        //Debug.Log(angle);
    }
    
  

    private void shooting()
    {
        if (Input.GetMouseButtonDown(0))
            {
            aimAnimator.SetTrigger("Shoot");
            Vector3 mousePosition = GetMouseWorldPosition();

            onshoot?.Invoke(this, new onshootEventArgs
            {
                gunendpointposition = aimgunendpointtransform.position,
                shootposition = mousePosition,
            });
            }

    }

}
