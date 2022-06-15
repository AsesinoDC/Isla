using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bateriaaaa : MonoBehaviour
{
    //variable para hacer referencia al sonido
    public AudioSource source;
    public AudioClip sonido;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        //mover sonido

        //posicion de la bateria = posicion del transdorm que tiene este script
        source.transform.position = transform.position;

        //reproducir sonido
        source.PlayOneShot(sonido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
