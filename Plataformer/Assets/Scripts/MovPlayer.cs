using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {
    private Rigidbody2D rgb;
    private Quaternion playerInvertido; 
    private bool right;
    private bool left;
    private bool jump;
    private bool coliPiso;
    [SerializeField]
    private float vel;
    private float velJump;

	void Awake () {
        rgb = GetComponent<Rigidbody2D>();
        playerInvertido.y = -190;
        right = false;
        left = false;
        jump = false;
        velJump = 300;
	}

    void FixedUpdate()
    {
        if (right)
        {
            transform.rotation = Quaternion.identity;
            rgb.AddRelativeForce(Vector3.right * vel, ForceMode2D.Impulse);
        }
        if (left)
        {
            transform.rotation = playerInvertido;
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
            if (name == "Player01")
            {
                right = Input.GetButton("Player01Right");
                left = Input.GetButton("Player01Left");
                if (Input.GetButtonDown("Player01Jump"))
                {
                    jump = true;
                }
            }
            else if (name == "Player02")
            {
                right = Input.GetButton("Player02Right");
                left = Input.GetButton("Player02Left");
                if (Input.GetButtonDown("Player02Jump"))
                {        
                    jump = true;
                }
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
