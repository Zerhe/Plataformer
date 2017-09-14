using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {
    private Rigidbody2D rgb;
    private SpriteRenderer sr;
    private bool right;
    private bool left;
    private bool jump;
    private bool coliPiso;
    private float vel;
    private float velJump;

	void Awake () {
        rgb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        right = false;
        left = false;
        jump = false;
        vel = 10;
        velJump = 300;
	}

    void FixedUpdate()
    {
        if (right)
        {
            sr.flipX = false;
            rgb.AddRelativeForce(Vector3.right * vel, ForceMode2D.Impulse);
        }
        if (left)
        {
            sr.flipX = true; ;
            rgb.AddRelativeForce(Vector3.left * vel, ForceMode2D.Impulse);
        }
        if (jump)
        {
            rgb.AddRelativeForce(Vector3.up * velJump, ForceMode2D.Impulse);
            jump = false;
        }
    }
    void Update ()
    {
        
        if (coliPiso)
        {
            right = Input.GetButton("Right");
            left = Input.GetButton("Left");
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }
	}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            coliPiso = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        coliPiso = false;
    }
}
