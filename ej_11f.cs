using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://docs.unity3d.com/ScriptReference/Collider.html

public class ej_11f : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
      Debug.Log(other.gameObject.tag);
    }
}

//https://docs.unity3d.com/es/current/Manual/CollidersOverview.html
/**
Colisiones:
No-trigger: al menos uno de los objetos debe ser no Kinematic
Si ambos son Kinematic OnCollisionEnter no se llama
En colisiones trigger la restricción anterior no se aplica.
Static: Los objetos Rigidbody colisionan pero el static collider no se mueve. 
No se debe alterar en tiempo de ejecución la propiedad
Rigidbody Collider: Se mueve por física y reaccionan a colisiones y fuerzas.
Kinematic Rigidbody: Se mueve con Transform liberándolo del motor de física.
**/
