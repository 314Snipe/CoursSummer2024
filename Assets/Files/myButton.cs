using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myButton : MonoBehaviour
{
    public Door door;
    private void OnCollisionEnter(Collision other){
        door.Open();
    }
    private void OnCollisionExit(Collision other){
        door.Close();
    }
}
