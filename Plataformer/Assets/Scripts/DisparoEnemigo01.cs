using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo01 : MonoBehaviour {
    [SerializeField]
    private float velMovInicial;
    [SerializeField]
    private float danio;
    private float velMov;
    private Vector3 direccion;

    void Start () {
        velMov = velMovInicial;
        direccion = Vector3.right;
    }
	void Update () {

        transform.Translate(direccion * Time.deltaTime * velMov);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "PlayerDisparo01")
            gameObject.SetActive(false);
    }
    public float GetDanio()
    {
        return danio;
    }
    public float GetVelMovInicial()
    {
        return velMovInicial;
    }
    public void SetVelMov(float valor)
    {
        velMov = valor;
    }
}
