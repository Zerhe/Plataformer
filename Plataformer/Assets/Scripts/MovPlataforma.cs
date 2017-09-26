using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlataforma : MonoBehaviour {
    [SerializeField]
    private CameraMov cameraMov;
    [SerializeField]
    private Vector3 direccion;
    [SerializeField]
    private float velMov;
    [SerializeField]
    private float tope;
    private bool player01Stay;
    private bool player02Stay;
    private bool cameraUP;

	void Start () {
        player01Stay = false;
        player02Stay = false;
        cameraUP = true;
	}
	
	void Update () {

        if (player01Stay && player02Stay)
        {
            if (cameraUP)
            {
                cameraMov.CamaraUp();
                cameraUP = false;
            }
            if (transform.position.y < tope)
            {
                transform.Translate(direccion * Time.deltaTime * velMov);
            }
        }
	}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player01")
            player01Stay = true;
        if (collision.gameObject.name == "Player02")
            player02Stay = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player01")
            player01Stay = false;
        if (collision.gameObject.name == "Player02")
            player02Stay = false;
    }
}
