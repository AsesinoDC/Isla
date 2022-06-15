using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject plataform;
    

    public Transform minPosition;
    public Transform maxPosition;

    public float speedMovement;


    private void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
            MovePlataform();
        }

       
    }

    private void MovePlataform()
    {
        plataform.transform.Translate(Vector3.up * Time.deltaTime * speedMovement);


        if (plataform.transform.position.y <= minPosition.transform.position.y)
        {
            speedMovement = -speedMovement;
            
        }
        if (plataform.transform.position.y >= maxPosition.transform.position.y)
        {
            speedMovement = -speedMovement;
            
        }

        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
