using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour {
    [SerializeField]
    private Transform playerTransform;
    private Vector3 limiteIzq;

	void Start () {

	}
	
	void Update () {
        if (transform.position.x < 0)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        if (transform.position.x > 75)
            transform.position = new Vector3(75, transform.position.y, transform.position.z);
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
    public void CamaraUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 23, transform.position.z);
    }
}
