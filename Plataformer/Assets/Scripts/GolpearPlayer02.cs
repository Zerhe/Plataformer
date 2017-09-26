using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpearPlayer02 : MonoBehaviour {
    [SerializeField]
    private GameObject espada;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetButtonDown("Player02Golpe01"))
        {
            espada.SetActive(true);
        }
        else
        {
            espada.SetActive(false);

        }
    }
}
