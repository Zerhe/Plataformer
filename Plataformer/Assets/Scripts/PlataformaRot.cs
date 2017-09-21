using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaRot : MonoBehaviour {
    private float velRot;
    void Start () {
        velRot = 100;
	}
	
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * velRot);
	}
}
