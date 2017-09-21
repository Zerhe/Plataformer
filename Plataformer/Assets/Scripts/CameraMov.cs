using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour {
    [SerializeField]
    private Transform playerTransform;
    private Vector3 posInicial;
    private Vector3 posFinal;

	void Start () {
        posInicial = transform.position;
        posInicial.x = 0;
        posFinal = transform.position;
        posFinal.x = 75;
	}
	
	void Update () {
        if (transform.position.x < 0)
            transform.position = posInicial;
        if (transform.position.x > 75)
            transform.position = posFinal;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(collision.gameObject.transform.position.x > transform.position.x)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 7);
            }
            else if (collision.gameObject.transform.position.x < transform.position.x)
            {
                transform.Translate(Vector3.right * Time.deltaTime * -7);
            }
        }
    }
}
