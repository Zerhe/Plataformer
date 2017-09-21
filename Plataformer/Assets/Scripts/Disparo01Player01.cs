using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo01Player01 : MonoBehaviour {
    [SerializeField]
    private Transform playerTransform;
    private float velMov;
    private Vector3 direccion;
    private float danio;

	void Start () {
        velMov = 10;
        danio = 1;
        direccion = Vector3.right;
		if(playerTransform.position.x > transform.position.x)
        {
            velMov = -velMov;
            direccion = Vector3.left;
        }
	}
	
	void Update () {
        transform.Translate(direccion * Time.deltaTime * velMov);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Disparo01")
        gameObject.SetActive(false);
    }
    public float GetDanio()
    {
        return danio;
    }
}
