using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTriggerScript : MonoBehaviour
{

    
    public GameObject teleportTarget;


    void OnTriggerStay(Collider other)
    {

        

        if (other.tag == "Player")
        {

            


            other.transform.position = teleportTarget.transform.position;



        }
    }

    
}
