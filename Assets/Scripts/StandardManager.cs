using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardManager : MonoBehaviour
{
    public GameObject D2, D3, D4, D5, E;

void OnTriggerEnter(Collider other){
       if(other.CompareTag("Player")){

         if(Holder.W2C1)
           D2.SetActive(true);

         if(Holder.W2C2)
           D3.SetActive(true);  
     
         if(Holder.W2C3)
           D4.SetActive(true);

         if (Holder.W2C4)
           D5.SetActive(true);

         if (Holder.W2C5)
           E.SetActive(true);
       }
     }
}
