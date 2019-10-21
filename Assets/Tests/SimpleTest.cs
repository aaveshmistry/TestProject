using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;

public class SimpleTest : MonoBehaviour
{
    [Test]

    public void NUintTest()
    {
        Assert.IsTrue(false, "NUint Test Failed");
    }

    [UnityTest]

    public IEnumerator UnityTest()
   {
        yield return new WaitForFixedUpdate();

        Assert.IsTrue(false, "UnityTestFailed");
   } 
}

