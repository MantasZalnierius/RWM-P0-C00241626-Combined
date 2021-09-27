using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Fizzbuzz
{
    // A Test behaves as an ordinary method
    [Test]
    public void CombinedTest()
    {
        int[] input = { 4, 3, 6, 30, 10, 12 };
        int[] output = combinedScript.combinedFilter(input);
        int[] expected = { 1, 0, 0, 0, 2, 0 };

        CollectionAssert.AreEqual(expected, output);
    }
}

