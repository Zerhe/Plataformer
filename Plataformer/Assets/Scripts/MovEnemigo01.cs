using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo01 : MonoBehaviour {
    private float velMov;
	void Start () {
        velMov = 10;	
	}
	
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * velMov);
	}
}
