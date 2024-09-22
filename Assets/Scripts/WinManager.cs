using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class WinManager : MonoBehaviour
{
    public bool w1 = false, w2 = false, w3 = false, w4 = false;
    public static int farthest = 0;
    char change =  '1';

    void OnTriggerEnter(Collider other){
       if(other.CompareTag("Player")){
          change = Holder.history[5];

         switch(change){
           case '1':
             Holder.L[0] = true;
             w1 = true;
             break;
           case '2':
             Holder.L[1] = true;
             w1 = true;
             break;
           case '3':
             Holder.L[2] = true;
             w1 = true;
             break;
           case '4':
             Holder.L[3] = true;
             w1 = true;
             break;
           case '5':
             Holder.L[4] = true;
             w1 = true;
             break;
           case '6':
             Holder.W2C1 = true;
             w2 = true;
             break;
           case '7': 
             Holder.W2C2 = true;
             w2 = true;
             break;
           case '8':
             Holder.W2C3 = true;
             w2 = true;
             break;
           case '9':
             Holder.W2C4 = true;
             w2 = true;
             break;
           case 'A':
             Holder.W2C5 = true;
             w2 = true;
             break;
           case 'B':
             Holder.endHalf[0] = true;
             w3 = true;
             break;
           case 'C':
             Holder.endHalf[1] = true;
             w3 = true;
             break;
           case 'D':
             Holder.endHalf[2] = true;
             w3 = true;
             break;
           case 'E':
             Holder.endHalf[3] = true;
             w3 = true;
             break;
           case 'F':
             Holder.endHalf[4] = true;
             w3 = true;
             break;
           default:
             break;
         }
// saving

         for (int a = 9; a > 0; a--){
	       if (Holder.endHalf[a]){
                 farthest = a + 11;
	       }
         }
         if (Holder.W2C5){
           farthest = 10;
         } else if (Holder.W2C4){
             farthest = 9;} else if (Holder.W2C3){
             farthest = 8;} else if (Holder.W2C2){
             farthest = 7;} else if (Holder.W2C1){
             farthest = 6;} else if (Holder.L[4]){
             farthest = 5;} else if (Holder.L[3]){
             farthest = 4;} else if (Holder.L[2]){
             farthest = 3;} else if (Holder.L[1]){
             farthest = 2;} else if (Holder.L[0]){
             farthest = 1;}

         using (StreamWriter writer = new StreamWriter("TheRealSaveFile.txt")){
           writer.WriteLine(farthest);
         }

         if (w1){
           SceneManager.LoadScene("LevelSelect");}
         if (w2){
           SceneManager.LoadScene("World2");}
         if (w3){
           SceneManager.LoadScene("World3");}
         if (w4){
           SceneManager.LoadScene("World3");}
       }
     }
}
