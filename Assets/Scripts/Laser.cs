using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject target, obstacle;
    public AudioSource bg;
    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
          if (hit.collider)
          {
            lr.SetPosition(1, hit.point);
          }
          if (hit.transform.gameObject == target){
            obstacle.SetActive(false);
            bg.Play();
            }
        } else lr.SetPosition(1, transform.forward*5000);    
    }
}