using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LockUnlock : MonoBehaviour
{
    public GameObject LevelDoor;
    public int index;
    public string scene;
    public AudioSource oof;

// this script allows the player to use a level portal if the previous level was completed. It checks this using the holder file, and plays a sound effect if the previous level was not cleared.
    void OnTriggerEnter(Collider other){ 
      if(other.CompareTag("Player")){ 
        if(Holder.L[index - 1]){
          SceneManager.LoadScene(scene);
        }else{
          oof.Play();
        }
      }
    }
}
