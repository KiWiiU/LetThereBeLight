using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopSong : MonoBehaviour
{
    public AudioSource bg;
    // Start is called before the first frame update
    void Start()
    {
        bg.loop = true;
        bg.Play();
// this script loops a given song when the scene it is in has loaded. The song stops when a different scene loads.
    }

   
}
