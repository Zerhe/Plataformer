using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour {
    [SerializeField]
    private Transform barraVidaT;
    [SerializeField]
    private SpriteRenderer barraVidaSR;
    private Vector3 scaleVida;
    private float vida;
    [SerializeField]
    private float maxVida;

    void Start () {
        vida = maxVida;
        scaleVida = Vector3.one;
    }
	
	void Update () {
        if (vida <= 0)
            Destroy(gameObject);
        /* cambiar color de la barra de vida
        if (vida < maxVida / 2)
            barraVidaSR.color = new Color(1, 0, 0, 1);*/
        scaleVida.x = vida / maxVida;
        barraVidaT.localScale = scaleVida;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo01Disparo")
        {
            print("gggggg");
            vida -= collision.gameObject.GetComponent<DisparoEnemigo01>().GetDanio();
        }
        if (name == "Player02" && collision.gameObject.tag == "PlayerDisparo01")
        {
            vida -= collision.gameObject.GetComponent<Disparo01Player01>().GetDanio();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo01")
        {
            vida -= 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (name == "Player01" && collision.gameObject.tag == "Espada")
        {
            vida -= collision.gameObject.GetComponent<Espada>().GetDanio();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pinche")
        {
            vida -= 0.2f;
        }
    }
}
