using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        PlayerStats playerStats;
        if (other.collider.TryGetComponent<PlayerStats>(out playerStats)){
            Debug.Log("Other object has playerStats");
            playerStats.coinCount += 1;
            Debug.Log(playerStats.coinCount + " " + playerStats.gameObject.name);
            Destroy(gameObject);
        } else{
            Debug.Log("No playerStats");
        }
    
    }
}