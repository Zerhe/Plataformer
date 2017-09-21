using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararPlayer01 : MonoBehaviour {
    [SerializeField]
    private Transform spawnDisparo01T;
    [SerializeField]
    private GameObject disparo01;
    private GameObject[] disparos01 = new GameObject[10];
    private int n;

    void Start () {
        n = 0;
        for (int i = 0; i < disparos01.Length; i++)
        {
            disparos01[i] = Instantiate(disparo01, spawnDisparo01T.position, spawnDisparo01T.rotation);
            disparos01[i].SetActive(false);
        }
    }
	
	void Update () {
		if(Input.GetButtonDown("Player01Disparo01"))
        {
            disparos01[n].transform.position = spawnDisparo01T.position;
            disparos01[n].transform.rotation = spawnDisparo01T.rotation;
            disparos01[n].SetActive(true);
            n++;
        }
        if (n == disparos01.Length)
            n = 0;
	}
}
