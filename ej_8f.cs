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

/**
CASI SIEMPRE QUE ROTO EL OBJETO EL TRANSLATE LO HAGO RESPECTO AL MUNDO
Vector3 dir = transform.forward;
dir.Normalize();
transform.Translate(dir * speed * Time.deltaTime, Space.World);
float giro = Input.GetAxis("Horizontal");
transform.Rotate(0.0f, giro, 0.0f, Space.Self);
**/
