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
         switch(change){
// this switch statment is used to tell the holder variable that a level has been cleared. Since this is a function, "change" is the parameter that represents the number level that was cleared.
           case 1:
             Holder.L[0] = true;
             break;
           case 2:
             Holder.L[1] = true;
             break;
           case 3:
             Holder.L[2] = true;
             break;
           case 4:
             Holder.L[3] = true;
             break;
           case 5:
             Holder.L[4] = true;
             break;
           case 6:
             Holder.W2C1 = true;
             break;
           case 7: 
             Holder.W2C2 = true;
             break;
           case 8:
             Holder.W2C3 = true;
             break;
           case 9:
             Holder.W2C4 = true;
             break;
           case 10:
             Holder.W2C5 = true;
             break;
           case 11:
             Holder.endHalf[0] = true;
             break;
           default:
             break;
         }

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
