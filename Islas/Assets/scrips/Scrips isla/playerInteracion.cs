using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteracion : MonoBehaviour
{
    public estadisticasPlayer playerState;
   // public Transform player;
    public Transform cameraPlayer;
    public Transform objetoVacio;
    public Transform gun;
    public GameObject Gun;
    public LayerMask lm;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "puerta" && playerState.baterycount >=3)
        {
            other.GetComponentInParent<Door>().OnOpenDoor();
        }

       if (other.transform.tag == "bateria")
        {
            //other.gameObject.SetActive(false);
            other.GetComponent<bateria>().desaparecer();
            playerState.baterycount++;
          /* if(gameObject.activeSelf == true)
            {
                Instantiate(sonido);
            }*/
        }

        if (other.tag == "Gun" && objetoVacio.childCount < 1)
        {
            Gun.transform.parent = gun;
            Gun.transform.localPosition = Vector3.zero;
            Gun.transform.localRotation = Quaternion.identity;
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Eboton"))
        {


            if (objetoVacio.childCount > 0 && Input.GetButtonDown("Eboton"))
            {
                objetoVacio.GetComponentInChildren<Rigidbody>().isKinematic = false;
                objetoVacio.DetachChildren();
                if(objetoVacio.childCount > 0)
                {


                    objetoVacio.GetChild(0).transform.parent = null;
                    //objetoVacio.GetComponentInChildren<Transform>().parent = null;
                } 
            }

           
            else
            {

                Debug.DrawRay(cameraPlayer.position, cameraPlayer.forward * 2, Color.red);
                RaycastHit hit;
                if (Physics.Raycast(cameraPlayer.position, cameraPlayer.forward, out hit, 2f, lm))
                {
                    if (Input.GetButtonDown("Eboton"))
                    {
                        hit.transform.GetComponent<Rigidbody>().isKinematic = true;

                        hit.transform.parent = objetoVacio;

                        hit.transform.localPosition = Vector3.zero;
                        //Debug.Log(hit.transform.name);

                    }
                }
            }
            
        }

            if (objetoVacio.childCount > 0 && gun.childCount > 0)
            {
                Gun.gameObject.SetActive(false);
            }

            if (objetoVacio.childCount == 0 && gun.childCount > 0)
            {
                Gun.gameObject.SetActive(true);
            }
        
        
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            Gun.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.V))
        { 
            Gun.gameObject.SetActive(true);
        
        }*/
        
            
    }
}
