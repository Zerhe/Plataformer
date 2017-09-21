using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownPlayer : MonoBehaviour {
    [SerializeField]
    private Sprite playerIdle;
    [SerializeField]
    private Sprite playerDown;
    private SpriteRenderer rendPlayer;
    private Vector3 scaleDown;

    private void Awake()
    {
        rendPlayer = GetComponent<SpriteRenderer>();
    }
    void Start ()
    {
        scaleDown = Vector3.one;
        scaleDown.y = 0.5f;
	}
	
	void Update ()
    {
		if (Input.GetButton("Down"))
        {
            transform.localScale = scaleDown;
            rendPlayer.sprite = playerDown;
        }
        if (Input.GetButtonUp("Down"))
        {
            transform.localScale = Vector3.one;
            rendPlayer.sprite = playerIdle;
        }
    }
}
