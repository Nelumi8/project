using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootprojectilesraycast : MonoBehaviour
{

    public Transform gunendpointposition;
    public GameObject impact;
    private GameObject instantiatedObj;
    public GameObject target;
    public LineRenderer linerend;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(shoot());

        }
    }

    IEnumerator shoot()

    {
        RaycastHit2D hitinfo = Physics2D.Raycast(gunendpointposition.position, gunendpointposition.right);
        
        if (hitinfo)
        {
            Debug.Log(hitinfo.transform.name);
            
            //if (hitinfo.transform.name == "target")
            if (target != null)
            {
                Instantiate(impact, hitinfo.point, Quaternion.identity);

                linerend.SetPosition(0, gunendpointposition.position);
                linerend.SetPosition(1, hitinfo.point);
            }

            else
            {
                linerend.SetPosition(0, gunendpointposition.position);
                linerend.SetPosition(1, gunendpointposition.position + gunendpointposition.right * 100);
            }

            linerend.enabled = true;

            yield return new WaitForSeconds(0.02f);

            linerend.enabled = false;
        }
    }

}