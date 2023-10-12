using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/Manual/class-InputManager.html

public class ej_1f : MonoBehaviour
{
    public float speed = 5.0f; // Valor de velocidad ajustable desde el Inspector

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // Valor entre -1 y 1, si lo pulsas poco es 0.algo 
        float movimientoVertical = Input.GetAxis("Vertical");

        if (movimientoHorizontal != 0 || movimientoVertical != 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                float resultado = speed * movimientoVertical;
                Debug.Log("Flecha Arriba: " + resultado);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                float resultado = speed * movimientoVertical;
                Debug.Log("Flecha Abajo: " + resultado);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                float resultado = speed * movimientoHorizontal;
                Debug.Log("Flecha Izquierda: " + resultado);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                float resultado = speed * movimientoHorizontal;
                Debug.Log("Flecha Derecha: " + resultado);
            }
        }
    }
}