using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/Transform.Translate.html

public class ej_3f : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.forward; // Dirección del movimiento ajustable desde el Inspector
    public float speed = 5.0f; // Velocidad ajustable desde el Inspector
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = moveDirection * speed * Time.deltaTime;
        transform.Translate(displacement, Space.Self);
    }
}
