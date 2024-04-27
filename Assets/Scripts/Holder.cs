using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
// this file holds the array that represents if a level has been cleared. This file is updated and the array is changed when levels are cleared.
    public static bool[] L = {false, false, false, false, false};
    public static bool W2C1 = false, W2C2 = false, W2C3 = false, W2C4 = false, W2C5 = false; 
    public static string history = "Playground";
    public static bool touch1 = false, touch2 = false, touch3 = false, touch4 = false;
    public static bool[] endHalf = {false, false, false, false, false, false, false, false, false, false};
}