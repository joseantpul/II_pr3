using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/Vector3.html

public class ej_4cubof : MonoBehaviour
{

    public float speed = 2.0f; // Valor de velocidad ajustable desde el Inspector
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float resultado = speed ;
            transform.Translate(Vector3.left * Time.deltaTime * resultado);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            float resultado = speed;
            transform.Translate(Vector3.right * Time.deltaTime * resultado);        
        }
    
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float resultado = speed;
            transform.Translate(Vector3.up * Time.deltaTime * resultado);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            float resultado = speed;
            transform.Translate(Vector3.down * Time.deltaTime * resultado);
        }
    }
}



/**
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // Valor entre -1 y 1, si lo pulsas poco es 0.algo 
        float movimientoVertical = Input.GetAxis("Vertical");

        if (movimientoHorizontal != 0) 
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                float resultado = speed * -movimientoHorizontal; // -movimientoHorizontal porq si no se va a la derecha
                //Debug.Log("movhor: " + movimientoHorizontal);
                //Debug.Log(resultado);
                //Debug.Log(Vector3.left * resultado);
                transform.Translate(Vector3.left * Time.deltaTime * resultado);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                float resultado = speed * movimientoHorizontal;
                transform.Translate(Vector3.right * Time.deltaTime * resultado);        
            }
        }
        if (movimientoVertical != 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                float resultado = speed * movimientoVertical;
                transform.Translate(Vector3.up * Time.deltaTime * resultado);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                float resultado = speed * -movimientoVertical;
                transform.Translate(Vector3.down * Time.deltaTime * resultado);
            }

        }



**/