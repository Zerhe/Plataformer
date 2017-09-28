using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    [SerializeField]
    private Vector3 scaleValue;
    private float timer;

	void Start () {
		
	}

	void Update () {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            print("asd");
            transform.localScale = scaleValue;
            timer = 0;
        }
        else
            transform.localScale = Vector3.one;
	}
}
