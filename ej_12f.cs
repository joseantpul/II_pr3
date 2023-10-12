using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/Rigidbody.AddForce.html

public class ej_12f : MonoBehaviour
{
    public string esferaNombre = "esfera";
    public float speed = 1.0f;
    private Transform esfera;
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        esfera = GameObject.Find(esferaNombre).transform;
        m_Rigidbody = GetComponent<Rigidbody>();
        if (esfera == null)
        {
            Debug.LogError("La esfera con el nombre '" + esferaNombre + "' no fue encontrada.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = esfera.position - transform.position;
        direccion.Normalize();
        Vector3 desplazamiento = direccion * speed * Time.deltaTime;
        m_Rigidbody.AddForce(desplazamiento);
    }


}
