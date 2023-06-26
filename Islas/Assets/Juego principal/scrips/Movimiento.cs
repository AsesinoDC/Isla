using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //declarar el tipo del rigidbody a nuestro objeto (jugador)
    private Rigidbody rb;

    //declarar publica para que se pueda modificar
    [Range(1,20)]
    public float velocidad = 5;
    public Vector3 direccion;
    private float gravedad = -9.8f;
    [Range(1,20)]
    public float salto = 5;
    private bool suelo;

    // Start is called before the first frame update
    void Start()
    {
        //capturar el rigidboy
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //mover
        //Captura el movimiento horizontal y vertical del teclado
        direccion.x = Input.GetAxis("Horizontal");
        direccion.z = Input.GetAxis("Vertical");
        direccion.y = gravedad * Time.deltaTime;

        if(suelo == true && direccion.y < 0)
        {
            direccion.y = -2f;

        }
        //Genera el vector del movimiento asociado, teniendo en cuenta la velocidad
        direccion =new Vector3(direccion.x * velocidad, 0.0f, direccion.y * velocidad);

        //aplica el movimiento al rigidbody
        rb.AddForce(direccion);

        
        //saltar
        if(suelo && Input.GetButton("Jump"))
        {
            direccion.y = Mathf.Sqrt(salto * -2 * gravedad);
            
        }

        
        
    }
}
