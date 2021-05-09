using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpring : MonoBehaviour
{
    public float SpringForce, lockControlTime;
    public bool IsAdditive, lockControl;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Boing!");
        if (IsAdditive)
        {
            other.transform.position = transform.position;
            other.attachedRigidbody.velocity += (transform.up * SpringForce);
        }
        else
        {
            other.transform.position = transform.position;
            other.attachedRigidbody.velocity = transform.up * SpringForce;
        }

        if(lockControl)
        {
            other.attachedRigidbody.GetComponent<BaseInput>().LockInputForAWhile(lockControlTime, false);
        }

    }
}
