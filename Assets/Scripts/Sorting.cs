using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Sorting : MonoBehaviour
{
    public static int[] nowTheyreNumbers = {0, 0, 0, 0, 0};
      
    public GameObject one, two, three, four, five;
    // these are the game objects shaped like the numbers they are named after

    // this starts when the player collides with the invisible box at the spawn point of the level selection scene, meaning that whenever the level select scene is loaded, this will run.
    void OnTriggerEnter(Collider other){
      // refreshing the values. True will be 1 in the mirror array and false will be 0
      for (int i = 0; i < 5; i++){ 
        if(Holder.L[i]){
          nowTheyreNumbers[i] = 1;
        }
        if(!Holder.L[i]){
          nowTheyreNumbers[i] = 0;
        }
      }
      
      // sorting from least to greatest (0s first, 1s last)
      int count = 0;
    
          //Sorting the array
            for (int j = 0; j <= nowTheyreNumbers.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= nowTheyreNumbers.Length - 2; i++)
                {
                    count = count + 1;
                    if (nowTheyreNumbers[i] > nowTheyreNumbers[i + 1])
                    {
                        int temp = nowTheyreNumbers[i + 1];
                        nowTheyreNumbers[i + 1] = nowTheyreNumbers[i];
                        nowTheyreNumbers[i] = temp;
                    }
                }
            }
      // determining how many levels the player still needs to clear by linear searching through the sorted array. Since we know that all the 0s are lined up before the 1s, we can stop after we see a 1
       
      int unfinished = 0;
    for(int x = 0; x < 5; x++){
      if(nowTheyreNumbers[x] == 0){
        unfinished++;
      }
      else{
        break;
      }
    }      
            
      // making certain decorations appear in the level select scene based on how many levels the player has cleared.
      switch(unfinished){
        case 0:
          one.SetActive(false);
          two.SetActive(false);
          three.SetActive(false);
          four.SetActive(false);
          five.SetActive(false);
          break;
        case 1:
          one.SetActive(true);
          two.SetActive(false);
          three.SetActive(false);
          four.SetActive(false);
          five.SetActive(false);
          break; 
        case 2:
          one.SetActive(false);
          two.SetActive(true);
          three.SetActive(false);
          four.SetActive(false);
          five.SetActive(false);
          break; 
        case 3:
          one.SetActive(false);
          two.SetActive(false);
          three.SetActive(true);
          four.SetActive(false);
          five.SetActive(false);
          break;
        case 4:
          one.SetActive(false);
          two.SetActive(false);
          three.SetActive(false);
          four.SetActive(true);
          five.SetActive(false);
          break;
        case 5:
          one.SetActive(false);
          two.SetActive(false);
          three.SetActive(false);
          four.SetActive(false);
          five.SetActive(true);
          break;
        default:
          one.SetActive(true);
          two.SetActive(true);
          three.SetActive(true);
          four.SetActive(true);
          five.SetActive(true);
          break;
      }      
    }
}
