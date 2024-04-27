using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class historycheck : MonoBehaviour
{
    public string place;
    public GameObject art;
    private string h = Holder.history;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (h.Equals(place))
            art.SetActive(true);
    }
}
