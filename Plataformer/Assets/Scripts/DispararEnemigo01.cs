using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararEnemigo01 : MonoBehaviour {
    private MovEnemigo01 movEnemigo01;
    [SerializeField]
    private Transform spawn01DisparoT;
    [SerializeField]
    private Transform spawn02DisparoT;
    [SerializeField]
    private GameObject disparo;
    private GameObject[] disparos = new GameObject[10];
    private float disparoTimer;
    private int n;

    private void Awake()
    {
        movEnemigo01 = GetComponent<MovEnemigo01>();
    }
    void Start () {
        disparoTimer = 0;
        n = 0;
        for (int i = 0; i < disparos.Length; i++)
        {
            disparos[i] = Instantiate(disparo, transform.position, transform.rotation);
            disparos[i].SetActive(false);
        }
    }
	
	void Update () {

        if (movEnemigo01.GetVelMov() == 0)
        {
            disparoTimer += Time.deltaTime;
            if (disparoTimer > 0.5)
            {
                disparoTimer = 0;
                int valor = Random.Range(0, 2);
                if (valor == 0)
                {
                    disparos[n].transform.position = spawn01DisparoT.position;
                    disparos[n].transform.rotation = spawn01DisparoT.rotation;
                    disparos[n].GetComponent<DisparoEnemigo01>().SetVelMov(disparos[n].GetComponent<DisparoEnemigo01>().GetVelMovInicial());
                    disparos[n].SetActive(true);
                    n++;
                }
                else if (valor == 1)
                {
                    disparos[n].transform.position = spawn02DisparoT.position;
                    disparos[n].transform.rotation = spawn02DisparoT.rotation;
                    disparos[n].GetComponent<DisparoEnemigo01>().SetVelMov(-disparos[n].GetComponent<DisparoEnemigo01>().GetVelMovInicial());
                    disparos[n].SetActive(true);
                    n++;
                }
            }
        }
        if (n == disparos.Length)
            n = 0;
    }
}
