using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalDeathLazer : MonoBehaviour
{
    private LineRenderer l;
    public GameObject t;
    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<LineRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {   
        l.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
          if (hit.collider)
          {
            l.SetPosition(1, hit.point);
          }
          if (hit.transform.gameObject == t)
            SceneManager.LoadScene("GameOver");
        } else l.SetPosition(1, transform.forward*5000);
    }
}
