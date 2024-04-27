using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialButton : MonoBehaviour
{
    public AudioSource bg;
    public int number;

    void OnTriggerEnter(Collider other){
       bg.Play();
       switch (number) {
         case 1:
           Holder.touch1 = true;
           break;
         case 2:
           Holder.touch2 = true;
           break;
         case 3:
           Holder.touch3 = true;
           break;
         case 4:
           Holder.touch4 = true;
           break;
       }
     }

  
}
