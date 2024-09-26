using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class darkOrbTeleport : MonoBehaviour
{
// This is a function because it's a script that takes a parameter, the name of the scene, and then teleports to that scene. This function is placed in many different objects across the game.
    
    private bool altGo = true;
    public string nxt, alt;
    public int change, w;
    void OnTriggerEnter(Collider other){
// when the object touches something, it will check if it is the player. If it is, it will "teleport" by loading a scene.
       if(other.CompareTag("Player")){
	 switch (w){
            case 0:
              altGo = Holder.L[0];
              break;
            case 1:
              altGo = Holder.W2C1;
              break;
            case 2:
              altGo = Holder.endHalf[0];
              break;
            case 3:
              altGo = Holder.endHalf[5];
              break;
            default:
              break;
         }
          if (altGo)
            SceneManager.LoadScene(alt);
          else 
            SceneManager.LoadScene(nxt);
	}

     }

}
