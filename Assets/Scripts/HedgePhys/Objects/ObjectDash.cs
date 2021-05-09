using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDash : MonoBehaviour
{
    public bool LockDirection, Snap, ControlLock;
    public float Speed, ControlLockTime;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dash!");
        other.transform.rotation = Quaternion.identity;
        BasePhysics ply = other.attachedRigidbody.GetComponent<BasePhysics>();
        //ResetPlayerRotation

        if (LockDirection)
        {
            other.attachedRigidbody.velocity = Vector3.zero;
            
        }
        ply.AddVelocity(transform.forward * Speed);

        if (Snap)
        {
            other.transform.position = transform.position;
        }

        if (ControlLock)
        {
            other.attachedRigidbody.GetComponent<BaseInput>().LockInputForAWhile(ControlLockTime, false);
        }


    }
}
