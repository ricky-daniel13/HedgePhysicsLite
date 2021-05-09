using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ActionManager ply = other.GetComponent<ActionManager>();
        if (ply.AttackPlayer())
        {
            Destroy(this.gameObject);
        }
        else
        {
            ply.DamagePlayer();
        }
        
    }
}
