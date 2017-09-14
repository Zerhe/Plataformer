using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour {
    [SerializeField]
    private Transform playerTransform;
    private Vector3 posInicial;

	void Start () {
        posInicial = transform.position;	
	}
	
	void Update () {
        if (transform.position.x < 3)
            transform.position = posInicial;
        if (transform.position.x > 75)
            transform.position = posInicial;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        print("asd");
        if(collision.gameObject.tag == "Player")
        {
            if(collision.gameObject.transform.position.x > transform.position.x)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 10);
            }
            else if (collision.gameObject.transform.position.x < transform.position.x)
            {
                transform.Translate(Vector3.right * Time.deltaTime * -10);
            }
        }
    }
}
