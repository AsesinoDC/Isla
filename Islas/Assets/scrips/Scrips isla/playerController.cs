using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Movimiento de camara")]
    public Vector2 mouseMovement;
    public Camera playerCamara;
    private float rotacionPlayerX;  
    public float sensiblidadCamara;

    [Header("movement controller")]
    public movementController movement;
    private void Update()
    {

        movement.Move(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        movement.Rotate(Input.GetAxis("Mouse X"));
        //capturar el movimiento del mouse
        mouseMovement = new Vector2(Input.GetAxis("Mouse X") * sensiblidadCamara, Input.GetAxis("Mouse Y") * sensiblidadCamara);
        //mouseMovement.x = Input.GetAxis("Mouse X") * sensibilidadCamara;
        //mouseMovement.y = Input.GetAxis("Mouse Y") * sensibilidadCamara;

        //almacenar la rotacion de la camara

        rotacionPlayerX -= mouseMovement.y;

        //limitar el movimiento del personaje la camara
        /* if (rotacionPlayerX > 40)
         {
             rotacionPlayerX = 40;
         }
         if (rotacionPlayerX < -40)
         {
             rotacionPlayerX = -40;
         }*/
        rotacionPlayerX = Mathf.Clamp(rotacionPlayerX, -40, 40);

        //rotar  el personaje en base al movimiento acumulado
        playerCamara.transform.localRotation = Quaternion.Euler(rotacionPlayerX, 0, 0);
    }
}
