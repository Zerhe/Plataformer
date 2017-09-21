using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer01 : MonoBehaviour {
    [SerializeField]
    private Transform barraVidaT;
    private Vector3 scaleVida;
    private float vida;
    private float maxVida;

    void Start () {
        maxVida = 100;
        vida = maxVida;
        scaleVida = Vector3.one;
    }
	
	void Update () {
        if (vida <= 0)
            Destroy(gameObject);
        scaleVida.x = vida / maxVida;
        barraVidaT.localScale = scaleVida;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo01")
        {
            vida -= 1;
            print(vida);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pinche")
        {
            vida -= 0.2f;
            print(vida);

        }
    }
}
