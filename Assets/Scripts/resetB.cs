using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetB : MonoBehaviour
{
    public AudioSource bg;
    void OnTriggerEnter(Collider other){
           bg.Play();

           Holder.touch1 = false;
   
           Holder.touch2 = false;
           
           Holder.touch3 = false;
           
           Holder.touch4 = false;
           
       
     }
}
