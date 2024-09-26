using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redo : MonoBehaviour
{
    private string place = "Playground";

    void OnTriggerEnter(Collider other){
      place = Holder.history;
      if(other.CompareTag("Player")){
          switch (place[5]){
            case 'A':
              SceneManager.LoadScene("Level10");
              break;
            case 'B':
              SceneManager.LoadScene("Level11");
              break;
            case 'C':
              SceneManager.LoadScene("Level12");
              break;
            case 'D':
              SceneManager.LoadScene("Level13");
              break;
            case 'E':
              SceneManager.LoadScene("Level14");
              break;
            case 'F':
              SceneManager.LoadScene("Level15");
              break;
            default:
              SceneManager.LoadScene(place);
              break;
          }        
      }
     }
}
