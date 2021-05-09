using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.GetComponent<ActionManager>().DamagePlayer();
    }
}
