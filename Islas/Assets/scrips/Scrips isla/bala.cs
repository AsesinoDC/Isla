using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocidad;
    void Update()
    {
        transform.Translate( Vector3.forward * velocidad * Time.deltaTime);

        
    }
}
