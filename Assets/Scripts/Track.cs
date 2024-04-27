using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Track : MonoBehaviour
{
    void Start(){
      string level = SceneManager.GetActiveScene().name;
      int l = level.Length;
      if (l <= 6)
        Holder.history = level;
      else {
        switch (level[6]){
          case '0':
            Holder.history = "-----A";
            break;
          case '1':
            Holder.history = "-----B";
            break;
	      case '2':
            Holder.history = "-----C";
            break;
          case '3':
            Holder.history = "-----D";
            break;
          case '4':
            Holder.history = "-----E";
            break;
          case '5':
            Holder.history = "-----F";
            break;
          case '6':
            Holder.history = "-----G";
            break;
          case '7':
            Holder.history = "-----H";
            break;
          case '8':
            Holder.history = "-----I";
            break;
          case '9':
            Holder.history = "-----J";
            break;
        }
      }
    }
}
