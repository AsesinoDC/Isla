using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }





    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entro en el trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Se mantiene en el trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio del trigger");
    }
    void Update()
    {
        
    }
}
