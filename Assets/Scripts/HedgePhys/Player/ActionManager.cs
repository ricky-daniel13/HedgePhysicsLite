using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    void Enter();
    void Exit();
}

public class ActionManager : MonoBehaviour
{
    int currAction;
    public int Action { get { return currAction; } }

    //Action Scrips, Always leave them in the correct order;

    public BasePhysics player;
    public ActionRegular Action00;
    public ActionJump Action01;
    public ActionHurt Action02;

    public void ChangeAction(int ActionToChange)
    {
        switch (currAction)
        {
            case 0:
                Action00.Exit();
                Action00.enabled = false;
                break;
            case 1:
                Action01.Exit();
                Action01.enabled = false;
                break;
            case 2:
                Action02.Exit();
                Action02.enabled = false;
                break;

        }

        //Put an case for all your actions here
        switch (ActionToChange)
        {
            case 0:
                Action00.enabled = true;
                Action00.Enter();
                break;
            case 1:
                Action01.enabled = true;
                Action01.Enter();
                break;
            case 2:
                Action02.enabled = true;
                Action02.Enter();
                break;

        }

        currAction = ActionToChange;

    }

    public void DamagePlayer()
    {
        if (Action != 2)
        {
            ChangeAction(2);
        }
    }

    public bool AttackPlayer()
    {
        Debug.Log("Trying to attack. Action: " + Action + " isRolling" + player.isRolling);
        if (Action == 1 || player.isRolling)
        {
            if (Action == 1)
            {
                Vector3 newSpeed = new Vector3(1, 0, 1);
                newSpeed = Vector3.Scale(player.rigidbody.velocity, newSpeed);
                newSpeed.y = Action01.EnmBouncingPower;
                player.rigidbody.velocity = newSpeed;
            }
            return true;
        }
        else
            return false;
    }

}
