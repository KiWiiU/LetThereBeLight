using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialRoom : MonoBehaviour
{
    public GameObject door;

// this allows the secret portal to the credits to show up if you beat level 5 already
    void OnTriggerEnter(Collider other){
      if(other.CompareTag("Player")){
        if(Holder.L[4]){
          door.SetActive(true);
        }
      }
    }
    
}
