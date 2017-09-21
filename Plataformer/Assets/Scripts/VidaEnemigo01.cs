using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo01 : MonoBehaviour {
    [SerializeField]
    private Transform barraVidaT;
    private Vector3 scaleVida;
    private float vida;
    private float maxVida;

	void Start () {
        maxVida = 50;
        vida = maxVida;
        scaleVida = Vector3.one;
	}
	
	void Update () {
        if (vida <= 0)
            Destroy(gameObject);
        scaleVida.x = vida / maxVida;
        barraVidaT.localScale = scaleVida;
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Disparo01")
        {
            vida -= collision.gameObject.GetComponent<Disparo01Player01>().GetDanio();
        }
    }
}
