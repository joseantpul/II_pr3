using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/KeyCode.html

public class ej_5esferaf : MonoBehaviour
{

    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            float resultado = speed ;
            transform.Translate(Vector3.left * Time.deltaTime * resultado);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            float resultado = speed;
            transform.Translate(Vector3.right * Time.deltaTime * resultado);        
        }
    
        if (Input.GetKey(KeyCode.W))
        {
            float resultado = speed;
            transform.Translate(Vector3.up * Time.deltaTime * resultado);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            float resultado = speed;
            transform.Translate(Vector3.down * Time.deltaTime * resultado);
        }

    }
}

/**

        //¿Es realmente necesario esto??? sin esto funciona igual
        //float movimientoHorizontal = Input.GetAxis("Horizontal"); 
        //float movimientoVertical = Input.GetAxis("Vertical");
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // Valor entre -1 y 1, si lo pulsas poco es 0.algo 
        float movimientoVertical = Input.GetAxis("Vertical");

        if (movimientoHorizontal != 0) 
        {
            if (Input.GetKey(KeyCode.A))
            {
                float resultado = speed * -movimientoHorizontal; // -movimientoHorizontal porq si no se va a la derecha
                transform.Translate(Vector3.left * Time.deltaTime * resultado);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                float resultado = speed * movimientoHorizontal;
                transform.Translate(Vector3.right * Time.deltaTime * resultado);        
            }
        }
        if (movimientoVertical != 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                float resultado = speed * movimientoVertical;
                transform.Translate(Vector3.up * Time.deltaTime * resultado);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                float resultado = speed * -movimientoVertical;
                transform.Translate(Vector3.down * Time.deltaTime * resultado);
            }

        }

**/