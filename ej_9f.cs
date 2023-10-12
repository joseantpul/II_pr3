using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// para que se vea drawRay hay que usar gizmos https://docs.unity3d.com/Manual/GizmosMenu.html

public class ej_9f : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    // https://docs.unity3d.com/ScriptReference/Collision.html
    void OnCollisionEnter(Collision collision) {
      Debug.Log(collision.gameObject.tag);
    }
}
