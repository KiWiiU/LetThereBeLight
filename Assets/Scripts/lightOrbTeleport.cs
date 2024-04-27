using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// if the object that is attached to this script collides with something, it will check if it is the player. If it is the player, it will teleport it to the destination, which in this case is set to the start of the scene.
public class lightOrbTeleport : MonoBehaviour
{
   public Transform player, DESTINATION;
   public GameObject playerg;
   public AudioSource a;
// the audio source is the sound effect that is played
    void OnTriggerEnter(Collider other){
     if (other.CompareTag("Player")){
      playerg.SetActive(false);
      a.Play();
      player.position = DESTINATION.position;
// the player must be temporarily deactivated so it can be moved.
      playerg.SetActive(true);
     }
    }
}
