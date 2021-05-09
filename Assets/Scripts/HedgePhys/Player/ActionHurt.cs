using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionHurt : MonoBehaviour, IState
{
    BasePhysics Player;
    ActionManager Actions;

    public float KnockbackUpwardsForce = 30;
    int counter;
    public float deadCounter { get; set; }

    public bool ResetSpeedOnHit = true;
    public float KnockbackForce = 30;

    public void Enter()
    {
        if (!ResetSpeedOnHit)
        {
            Vector3 newSpeed = new Vector3((Player.rigidbody.velocity.x / 2), KnockbackUpwardsForce, (Player.rigidbody.velocity.z / 2));
            newSpeed.y = KnockbackUpwardsForce;
            Player.rigidbody.velocity = newSpeed;
        }
        else
        {
            Vector3 newSpeed = -transform.forward * KnockbackForce;
            newSpeed.y = KnockbackUpwardsForce;
            Player.rigidbody.velocity = newSpeed;
        }
    }

    public void Exit()
    {
        return;
    }

    // Start is called before the first frame update
    void Awake()
    {
        Player = GetComponent<BasePhysics>();
        Actions = GetComponent<ActionManager>();
    }

    void FixedUpdate()
    {

        //Get out of Action
        counter += 1;

        if (Player.Grounded && counter > 20)
        {
            Actions.ChangeAction(0);
            counter = 0;
        }

    }
}
