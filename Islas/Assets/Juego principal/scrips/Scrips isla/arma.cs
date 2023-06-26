using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    
    public Transform canon;
    public GameObject bala;
    public Transform gun;
    public float fuerza;
    public int magazineActual;
    public int magazineMax = 5;
    public AudioClip sonido;
    public AudioSource audio;
    public float volumen = 1f;


    private void Start()
    {
        magazineActual = magazineMax;
    }
    private void Update()
    {

        if (/*Input.GetKeyDown(KeyCode.Mouse0)*/Input.GetButtonDown("Fire1") && gun.childCount > 0 && magazineActual > 0)
        {
            Disparo();
            
        }

        if(Input.GetButtonDown("Recarga") && gun.childCount > 0)
        {
            Reload();
        }

    }

    private void Disparo()
    {
        
       GameObject go = Instantiate(bala , canon.transform.position, canon.transform.rotation);
       go.GetComponent<Rigidbody>().AddForce(go.transform.forward * fuerza, ForceMode.Impulse);

        AudioSource.PlayClipAtPoint(sonido, gameObject.transform.position);

        Destroy(go.gameObject, 2f);

        magazineActual--;
       
    }

    void Reload()
    {
        magazineActual = magazineMax;
    }
}
