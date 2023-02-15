using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("raycast");
    }

    //public void ChangeScene2()
    //{
        //SceneManager.LoadScene("distance checker");
    //}

    public void ChangeScene3()
    {
        SceneManager.LoadScene("using collider");
    }

    public void ChangeScene4()
    {
        SceneManager.LoadScene("menu");
    }
}
