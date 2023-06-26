using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(playerController))]
public class movementController : MonoBehaviour
{
    [Header("Movimiento del personaje")]
    public float speedMovementAcual;
    public Vector3 direccion;
    public CharacterController controller;

    [Header("Gravedad")]
    public Vector3 desplazamientoY;
    public float gravity = -9.8f;
    public float salto;

    [Header("Rotacion")]
    public float rotacionPlayerY;




    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {

        /* if (Input.GetButtonDown("Fire1"))
         {
              Debug.Log("mouse, felicidades");
         }


         //mover personaje
         direccion.x = Input.GetAxis("Horizontal");
          if (Input.GetAxis("Horizontal") != 0)
         {
             direccion.x = (Input.GetAxis("Horizontal"));
         }
         direccion.z = Input.GetAxis("Vertical");
          if (Input.GetAxis("Vertical") != 0)
         {
              direccion.z = (Input.GetAxis("Vertical"));
         }

         */

        

        //salto
        //calcular la graveda por frame
        desplazamientoY.y += gravity * 1.5f * Time.deltaTime;

         //mover el personaje en "y" en base a la gravedad calculada
        controller.Move(desplazamientoY * Time.deltaTime);

        //si esta tocando el suelo y el movimiento en y es negativo resetear la gravedad
        if (controller.isGrounded && desplazamientoY.y < 0)
        {
            desplazamientoY.y = -2;
        }
        
       //si el personaje esta tocando el suelo y al precionar la tecla de salto, calcular el salto del personaje
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            desplazamientoY.y = Mathf.Sqrt(salto * -2 * gravity);
        }

        
    }

    public void Move(float Vertical, float Horizontal ) 
    {
        //capturar los valores para moverse
        direccion.x = Horizontal;
        direccion.z = Vertical;

        //mover al jugador
        //transformar la direccion en cordenadas al jugador
        // direccion = transform.TransformDirection(direccion);
        controller.Move(transform.TransformDirection(direccion) * Time.deltaTime * speedMovementAcual);
    }

    public void Rotate(float rotateValue)
    {

        rotacionPlayerY += rotateValue;

        //rotar  el personaje en base al movimiento acumulado

        controller.transform.rotation = Quaternion.Euler(0, rotacionPlayerY, 0);
    }

    

}
