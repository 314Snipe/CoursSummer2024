using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    Transform target;
    void Start(){
        target = PlayerStats.stats.transform;
    }
}
