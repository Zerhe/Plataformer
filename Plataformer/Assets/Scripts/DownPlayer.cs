using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownPlayer : MonoBehaviour {
    Vector3 scalePlayer;
	void Start ()
    {
        scalePlayer = transform.localScale;
	}
	
	void Update ()
    {
		if (Input.GetButton("Down"))
        {
            transform.localScale = Vector3.one;
        }
        if (Input.GetButtonUp("Down"))
        {
            transform.localScale = scalePlayer;
        }
	}
}
