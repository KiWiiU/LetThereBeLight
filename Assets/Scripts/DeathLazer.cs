using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathLazer : MonoBehaviour
{
    private LineRenderer lr;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(40f * Time.deltaTime, 0f, 0f, Space.Self);
        
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
          if (hit.collider)
          {
            lr.SetPosition(1, hit.point);
          }
          if (hit.transform.gameObject == target)
            SceneManager.LoadScene("GameOver");
        } else lr.SetPosition(1, transform.forward*5000);
    }
}
