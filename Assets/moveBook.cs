﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBook : MonoBehaviour
{
    
    public Transform target;
    public float t;
    public GameObject clue1;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    public void sceptor()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.Lerp(a, b, t);
       ShowCursor();

    }
    public void ShowCursor()
    {

        clue1.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}