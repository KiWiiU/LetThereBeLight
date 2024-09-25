using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour
{
public string le = "__";
    // Start is called before the first frame update
    void Start()
    {
      if (!File.Exists("TheRealSaveFile.txt"))
        File.Create("TheRealSaveFile.txt").Close();
      using (StreamReader reader = new StreamReader("TheRealSaveFile.txt")){
        if(!reader.EndOfStream){
          le = le + reader.ReadLine();
        }
      }
      switch (le){
        case "__1":
          Holder.L[0] = true;
          break;
        case "__2":
          Holder.L[1] = true;
	      Holder.L[0] = true;
          break;
        case "__3":
          Holder.L[2] = true;
          Holder.L[0] = true;
	      Holder.L[1] = true;
          break;
        case "__4":
          Holder.L[3] = true;
          Holder.L[0] = true;
          Holder.L[1] = true;
          Holder.L[2] = true;
          break;
        case "__5":
          Holder.L[4] = true;
          Holder.L[0] = true;
          Holder.L[1] = true;
          Holder.L[2] = true;
          Holder.L[3] = true;
          break;
        case "__6":
          Holder.W2C1 = true;
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
          break;
        case "__7":
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
		  break;
        case "__8":
	      Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
          break;
        case "__9":
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
          break;
        case "__10":
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
	      Holder.W2C5 = true;
	      break;
        case "__11":
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
	      Holder.W2C5 = true;
          Holder.endHalf[0] = true;
          break;
        case "__12":
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
	      Holder.W2C5 = true;
          Holder.endHalf[0] = true;
          Holder.endHalf[1] = true;
          break;
        case "__13":
          Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
	      Holder.W2C5 = true;
          Holder.endHalf[0] = true;
          Holder.endHalf[1] = true;
		  Holder.endHalf[2] = true;
		  break;
		case "__14":
		  Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
	      Holder.W2C5 = true;
          Holder.endHalf[0] = true;
          Holder.endHalf[1] = true;
		  Holder.endHalf[2] = true;
		  Holder.endHalf[3] = true;
		  break;
		case "__15":
		  Holder.L[0] = true;
	      Holder.L[1] = true;
	      Holder.L[2] = true;
	      Holder.L[3] = true;
	      Holder.L[4] = true;
	      Holder.W2C1 = true;
	      Holder.W2C2 = true;
	      Holder.W2C3 = true;
	      Holder.W2C4 = true;
	      Holder.W2C5 = true;
          Holder.endHalf[0] = true;
          Holder.endHalf[1] = true;
		  Holder.endHalf[2] = true;
		  Holder.endHalf[3] = true;
		  Holder.endHalf[4] = true;
		  break;
        default:
	      break;
      }
    }
}
