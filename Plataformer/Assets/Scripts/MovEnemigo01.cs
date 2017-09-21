using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo01 : MonoBehaviour {
    [SerializeField]
    private Transform playerTransform;
    private float velMovInicial;
    private float velMov;

	void Start () {
        velMovInicial = 8;
        velMov = velMovInicial;
	}
	
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * velMov);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plataforma" || collision.gameObject.tag == "Pared" || collision.gameObject.tag == "Enemigo01")
        {
            if (velMov > 0)
                velMov = -velMovInicial;
            else if (velMov < 0)
                velMov = velMovInicial;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player01")
        {
            velMov = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player01")
        {
            int valor = Random.Range(0, 2);
            if (valor == 0)
                velMov = velMovInicial;
            else if (valor == 1)
                velMov = -velMovInicial;
        }
    }
}
