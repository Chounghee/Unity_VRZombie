using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    bool isChange01;
    bool isChange02;
    bool isChange03;

    public void Change01()
    {
        if (!isChange01)
        {           
            SceneManager.LoadScene(0);
            isChange01 = true;
        }
        else
        {
            isChange01 = false;
        }
    }
    public void Change03()
    {
        if (!isChange03)
        {
            SceneManager.LoadScene(1);
            isChange03 = true;
        }
        else
        {
            isChange03 = false;
        }
    }

    public void Change02()
    {
        if (!isChange02)
        {
            SceneManager.LoadScene(2);
            isChange02 = true;
        }
        else
        {
            isChange02 = false;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
