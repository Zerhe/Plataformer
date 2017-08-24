using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {
    private Rigidbody2D rgb;
    private JumpPlayer jumpState;
    private DownPlayer downPlayer;
    private bool right;
    private bool left;
    private bool jump;
    private bool down;
    private float vel;
    private float velJump;

	void Awake () {
        rgb = GetComponent<Rigidbody2D>();
        right = false;
        vel = 5;
        velJump = 50;
	}

    void FixedUpdate()
    {
        if (right)
            rgb.AddRelativeForce(Vector3.right * vel, ForceMode2D.Impulse);
        if (left)
            rgb.AddRelativeForce(Vector3.left * vel, ForceMode2D.Impulse);
        if (jump)
            rgb.AddRelativeForce(Vector3.up * velJump, ForceMode2D.Impulse);
        if (down)
            rgb.AddRelativeForce(Vector3.right * vel, ForceMode2D.Impulse);
    }
    void Update ()
    {
        right = Input.GetButton("Right");
        left = Input.GetButton("Left");
        jump = Input.GetButtonUp("Jump");
        down = Input.GetButton("Down");
        
        
        
	}
}
