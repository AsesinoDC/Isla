using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(movementController))]
public class enemyController : MonoBehaviour
{
    
    public movementController movement;
    public Transform jugador;
    public float rangoOfDetection = 15f;

    private void Update()
    {

        float distance = Vector3.Distance(transform.position, jugador.position);
         

        if (distance <= rangoOfDetection)
        {

            //movement.Move(1, 0);


            //Vector3.Dot(transform.position, jugador.position);
            Vector3 adelante = transform.TransformDirection(Vector3.forward);
            Vector3 toJugador =  jugador.position - transform.position ;

            adelante = adelante.normalized;
            toJugador = toJugador.normalized;
            
             if (Vector3.Dot(adelante, toJugador) < 0.99)
            {
                Debug.Log("adelante");
                movement.Rotate(1);


                if (Vector3.Dot(toJugador, adelante) > 0.99)
                {
                    Debug.Log("atras");
                    movement.Rotate(-1);

                }

            }

            

            

        }
    }
}
