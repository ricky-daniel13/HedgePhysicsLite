using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionJump : MonoBehaviour, IState
{
    BasePhysics Player;
    ActionManager Actions;
    public Transform Model;
    public GameObject spinModel, normalModel;

    public float skinRotationSpeed=20;

    public Vector3 InitialNormal { get; set; }
    public float Counter { get; set; }
    public float JumpDuration=0.09f;
    public float SlopedJumpDuration=0.09f;
    public float JumpSpeed=10;
    public float JumpSlopeConversion=0.02f;
    public float StopYSpeedOnRelease=2;
    public float RollingLandingBoost=0;
    public float EnmBouncingPower;

    float jumpSlopeSpeed;

    public void Enter()
    {
        Counter = 0;
        jumpSlopeSpeed = 0;
        InitialNormal = Player.GroundNormal;

        //SnapOutOfGround to make sure you do jump
        transform.position += (InitialNormal * 0.3f);

        //Jump higher depending on the speed and the slope you're in
        if (Player.rigidbody.velocity.y > 0 && Player.GroundNormal.y > 0)
        {
            jumpSlopeSpeed = Player.rigidbody.velocity.y * JumpSlopeConversion;
        }

        spinModel.SetActive(true);
        normalModel.SetActive(false);
    }

    public void Exit()
    {
        spinModel.SetActive(false);
        normalModel.SetActive(true);
        return;
    }

    void Awake()
    {
        Player = GetComponent<BasePhysics>();
        Actions = GetComponent<ActionManager>();
    }

    void Update()
    {
        Vector3 VelocityMod = new Vector3(Player.rigidbody.velocity.x, 0, Player.rigidbody.velocity.z);
        Quaternion CharRot = Quaternion.LookRotation(VelocityMod, transform.up);
        Model.rotation = Quaternion.Lerp(Model.rotation, CharRot, Time.deltaTime * skinRotationSpeed);
    }

    void FixedUpdate()
    {

        //Jump action
        Counter += Time.deltaTime;

        if (!Input.GetButton("Jump") && Counter < JumpDuration)
        {
            Counter = JumpDuration;
        }

        //Keep Colliders Rotation to avoid collision Issues
        if (Counter < 0.2f)
        {
            //transform.rotation = Quaternion.FromToRotation(transform.up, InitialNormal) * transform.rotation;
        }

        //Add Jump Speed
        if (Counter < JumpDuration)
        {
            Player.isRolling = false;
            if (Counter < SlopedJumpDuration)
            {
                Player.AddVelocity(InitialNormal * (JumpSpeed));
            }
            else
            {
                Player.AddVelocity(new Vector3(0, 1, 0) * (JumpSpeed));
            }
            //Extra speed
            Player.AddVelocity(new Vector3(0, 1, 0) * (jumpSlopeSpeed));
        }

        //Cancell Jump
        if (Player.rigidbody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            Vector3 Velocity = new Vector3(Player.rigidbody.velocity.x, Player.rigidbody.velocity.y, Player.rigidbody.velocity.z);
            Velocity.y = Velocity.y - StopYSpeedOnRelease;
            Player.rigidbody.velocity = Velocity;
        }


        //End Action
        if (Player.Grounded && Counter > SlopedJumpDuration)
        {
            Actions.ChangeAction(0);
        }

    }
}
