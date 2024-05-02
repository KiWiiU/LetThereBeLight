using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
      if (other.CompareTag("Player")){
        if (Holder.endHalf[4]){
          // SceneManager.LoadScene("World4");
          SceneManager.LoadScene("World3");
        }
        else if (Holder.W2C5){
          SceneManager.LoadScene("World3");
        }
        else if (Holder.L[4]){
           SceneManager.LoadScene("World2");
        } else {
           SceneManager.LoadScene("LevelSelect");
        }
      }
    }
}
