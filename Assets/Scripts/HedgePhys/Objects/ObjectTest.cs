using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Activated");
    }
}
