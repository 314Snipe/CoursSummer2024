using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
 public int jumpCount = 2;
 public int maxjumpCount = 2;
 public float jumpForce = 10.0f;
 public Collider legs;
 public Rigidbody rigidbody;
 private void Update(){
    if(Input.GetKeyDown(KeyCode.Space)| Input.GetKeyDown(KeyCode.W)) {
        if (jumpCount <= 0){
            return;
        }
        jumpCount -= 1;
        rigidbody.AddForce(Vector3.up*jumpForce, ForceMode.VelocityChange);
        Debug.Log("Jumped");
    }
 }
    private void OnTriggerEnter(Collider other){
        Debug.Log("Grounded");
        jumpCount=maxjumpCount;

    }
}
