using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej_12movf : MonoBehaviour
{
    public float speed = 100.0f;
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       m_Rigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            float resultado = speed;
            m_Rigidbody.AddForce(Vector3.left * Time.deltaTime * resultado);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            float resultado = speed;
            m_Rigidbody.AddForce(Vector3.right * Time.deltaTime * resultado);        
        }
    
        if (Input.GetKey(KeyCode.U))
        {
            float resultado = speed;
            m_Rigidbody.AddForce(Vector3.forward * Time.deltaTime * resultado);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            float resultado = speed;
            m_Rigidbody.AddForce(Vector3.back * Time.deltaTime * resultado);
        }
    }
}
