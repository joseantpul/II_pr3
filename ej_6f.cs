using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej_6f : MonoBehaviour
{

    public string esferaNombre = "esfera";
    public float speed = 1.0f;
    private Transform esfera;
    void Start()
    {
        esfera = GameObject.Find(esferaNombre).transform;

        if (esfera == null)
        {
            Debug.LogError("La esfera con el nombre '" + esferaNombre + "' no fue encontrada.");
        }
    }

    void Update()
    {
        Vector3 direccion = esfera.position - transform.position;
        direccion.Normalize();
        Vector3 desplazamiento = direccion * speed * Time.deltaTime;
        transform.Translate(desplazamiento);     
    }
}
