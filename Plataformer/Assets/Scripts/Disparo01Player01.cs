﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo01Player01 : MonoBehaviour {
    [SerializeField]
    private float velMov;
    private Vector3 direccion;
    [SerializeField]
    private float danio;

	void Start () {
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
}
