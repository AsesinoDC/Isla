using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguimiento : MonoBehaviour
{
    //referencia al jugador
    public GameObject jugador;

    //para registrar la diferencia entre la posicion de la camara y el jugador
    private Vector3 camara;
    // Start is called before the first frame update
    void Start()
    {
        //diferente entre la posicion de la cama y la del jugador
        camara = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Actualiza la posicion de la camara
        transform.position = jugador.transform.position + camara;
    }
}
