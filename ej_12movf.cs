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

/**
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Store user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        m_Rigidbody.MovePosition(transform.position + m_Input * Time.fixedDeltaTime * m_Speed);
    }


**/
