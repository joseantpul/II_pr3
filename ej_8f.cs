using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/Transform.Rotate.html

public class ej_8f : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed = 30.0f; 

    void Start()
    {

    }

    void Update()
    {
        //transform.LookAt(transform.forward);
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
