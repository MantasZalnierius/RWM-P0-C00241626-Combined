using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combinedScript : MonoBehaviour
{
    public static int[] combinedFilter(int[] xs)
    {
        return Modulo3.mod3(FizzBuzz.CalculateFizzBuzz(xs));
    }
}
