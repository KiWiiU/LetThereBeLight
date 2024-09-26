using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class RedoWIN : MonoBehaviour
{
    private string place = "Playground";

    void OnTriggerEnter(Collider other)
    {
        place = Holder.history;
        if (other.CompareTag("Player"))
        {
            switch (place[5])
            {
                case '1':
                    Holder.L[0] = true;
                    SceneManager.LoadScene("Level1");
                    break;
                case '2':
                    Holder.L[1] = true;
                    SceneManager.LoadScene("Level2");
                    break;
                case '3':
                    Holder.L[2] = true;
                    SceneManager.LoadScene("Level3");
                    break;
                case '4':
                    Holder.L[3] = true;
                    SceneManager.LoadScene("Level4");
                    break;
                case '5':
                    Holder.L[4] = true;
                    SceneManager.LoadScene("Level5");
                    break;
                case '6':
                    Holder.W2C1 = true;
                    SceneManager.LoadScene("Level6");
                    break;
                case '7':
                    Holder.W2C2 = true;
                    SceneManager.LoadScene("Level7");
                    break;
                case '8':
                    Holder.W2C3 = true;
                    SceneManager.LoadScene("Level8");
                    break;
                case '9':
                    Holder.W2C4 = true;
                    SceneManager.LoadScene("Level9");
                    break;
                case 'A':
                    Holder.W2C5 = true;
                    SceneManager.LoadScene("Level10");
                    break;
                case 'B':
                    Holder.endHalf[0] = true;
                    SceneManager.LoadScene("Level11");
                    break;
                case 'C':
                    Holder.endHalf[1] = true;
                    SceneManager.LoadScene("Level12");
                    break;
                case 'D':
                    Holder.endHalf[2] = true;
                    SceneManager.LoadScene("Level13");
                    break;
                case 'E':
                    Holder.endHalf[3] = true;
                    SceneManager.LoadScene("Level14");
                    break;
                case 'F':
                    Holder.endHalf[4] = true;
                    SceneManager.LoadScene("Level15");
                    break;
                default:
                    SceneManager.LoadScene(place);
                    break;
            }
            int farthest = 1;
            if (Holder.W2C5)
            {
                farthest = 10;
            }
            else if (Holder.W2C4)
            {
                farthest = 9;
            }
            else if (Holder.W2C3)
            {
                farthest = 8;
            }
            else if (Holder.W2C2)
            {
                farthest = 7;
            }
            else if (Holder.W2C1)
            {
                farthest = 6;
            }
            else if (Holder.L[4])
            {
                farthest = 5;
            }
            else if (Holder.L[3])
            {
                farthest = 4;
            }
            else if (Holder.L[2])
            {
                farthest = 3;
            }
            else if (Holder.L[1])
            {
                farthest = 2;
            }
            else if (Holder.L[0])
            {
                farthest = 1;
            }
            for (int a = 9; a > 0; a--)
            {
                if (Holder.endHalf[a])
                {
                    farthest = a + 11;
                }
            }
            using (StreamWriter writer = new StreamWriter("TheRealSaveFile.txt"))
            {
                writer.WriteLine(farthest);
            }
        }
    }
}
