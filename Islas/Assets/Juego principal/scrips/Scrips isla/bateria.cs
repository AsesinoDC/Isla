using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bateria : MonoBehaviour
{
    
    public AudioSource emite;
    public AudioClip sonido;
    public float volumen = 1f;
    // Start is called before the first frame update

    
    public void desaparecer()
    {
        AudioSource.PlayClipAtPoint(sonido, gameObject.transform.position);

        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
