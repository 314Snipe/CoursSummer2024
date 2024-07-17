using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myTrigger : MonoBehaviour
{
    private void OnTriggerEnter (Collider other){
        Debug.Log("Entered trigger");
    }
    private void OnTriggerStay (Collider other){
        Debug.Log("In trigger");
    }
    private void OnTriggerExit (Collider other){
        Debug.Log("Left trigger");
    }
    
}
