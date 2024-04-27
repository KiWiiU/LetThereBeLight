using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public Transform Player;

    // Update is called once per frame, and every time it's called, it sets the enemy's location to the place the player currently is.
    void Update()
    {
        Enemy.SetDestination(Player.position);
    }
}
