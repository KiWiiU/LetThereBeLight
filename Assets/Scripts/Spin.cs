using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public int IDnum;
    private static bool should = true;
    void Update()
    {
      switch (IDnum){
        case 1:
          should = !Holder.touch1;
          break;
        case 2:
          should = !Holder.touch2;
          break;
        case 3:
          should = !Holder.touch3;
          break;
        case 4:
          should = !Holder.touch4;
          break;
      }
      if (should)
        transform.Rotate(0f, 0f, 30f * Time.deltaTime, Space.Self);
    }
}
