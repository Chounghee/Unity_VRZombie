using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEmo : MonoBehaviour
{
    public Animator[] m_animators;
    private float timer = 0.0f;
    private void Start()
    {
        m_animators = FindObjectsOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        if(timer > 5.0f)
        {
            GUILayout.EndHorizontal();
        }
        
        //GUILayout.EndHorizontal();
    }
}
