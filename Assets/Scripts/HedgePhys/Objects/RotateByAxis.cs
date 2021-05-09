using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByAxis : MonoBehaviour
{
    public float rotatePower;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotatePower, 0);
    }
}
