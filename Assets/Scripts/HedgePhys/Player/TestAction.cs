using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAction : MonoBehaviour
{
    BasePhysics Player;
    public float JumpSlopeConversion = 0.02f;
    public float JumpSpeed = 10f;

    private void Awake()
    {
        Player = GetComponent<BasePhysics>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            TestJump();
        }
    }

    void TestJump()
    {
        Vector3 InitialNormal = Player.GroundNormal;

        //SnapOutOfGround to make sure you do jump
        transform.position += (InitialNormal * 0.3f);

        float jumpSlopeSpeed = 0;

        //Jump higher depending on the speed and the slope you're in
        if (Player.rigidbody.velocity.y > 0 && Player.GroundNormal.y > 0)
        {
            jumpSlopeSpeed = Player.rigidbody.velocity.y * JumpSlopeConversion;
        }

        Player.AddVelocity(new Vector3(0, 1, 0) * (jumpSlopeSpeed));

        Player.AddVelocity(new Vector3(0, 1, 0) * (JumpSpeed));
    }
}
