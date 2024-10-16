using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaColision : MonoBehaviour
{
   void OnTriggerEnter(Collider objetoOtro)
    {
        Destroy(gameObject);
        Destroy(objetoOtro.gameObject);
    }
}
