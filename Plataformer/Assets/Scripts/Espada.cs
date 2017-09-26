using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour {

    private float danio;

	void Start () {
        danio = 3;
        gameObject.SetActive(false);
	}
	
	void Update () {
		
	}
    public float GetDanio()
    {
        return danio;
    }
}
