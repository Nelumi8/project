using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impact;
    private GameObject instantiatedObj;

    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }

    void OnTriggerEnter2D (Collider2D hitinfo)
    {
        
        if (hitinfo.name == "target")
        {
            instantiatedObj = Instantiate(impact, transform.position, transform.rotation);
            //Debug.Log(hitinfo.name);
            Destroy(gameObject);
            //Thread.Sleep(3000);
            //Destroy(instantiatedObj);
        }
       
        
    }
}
