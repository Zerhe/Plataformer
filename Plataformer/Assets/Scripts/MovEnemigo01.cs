using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo01 : MonoBehaviour {
    [SerializeField]
    private Transform playerTransform;
    private float velMovInicial;
    private float velMov;
    private float velGuard;

	void Start () {
        velMovInicial = 5;
        velMov = velMovInicial;
	}
	
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * velMov);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            if (velMov > 0)
                velMov = -velMovInicial;
            else if (velMov < 0)
                velMov = velMovInicial;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            velGuard = velMov;
            velMov = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            velMov = velGuard;
    }
}
