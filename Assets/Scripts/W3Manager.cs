using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W3Manager : MonoBehaviour
{
    public GameObject D2, D3, D4, D5, E;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Holder.endHalf[0])
                D2.SetActive(true);

            if (Holder.endHalf[1])
                D3.SetActive(true);

            if (Holder.endHalf[2])
                D4.SetActive(true);

            if (Holder.endHalf[3])
                D5.SetActive(true);

            if (Holder.endHalf[4])
                E.SetActive(true);
        }
    }
}
