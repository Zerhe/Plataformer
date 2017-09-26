using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownPlayer : MonoBehaviour {
    [SerializeField]
    private Sprite playerIdle;
    [SerializeField]
    private Sprite playerDown;
    private SpriteRenderer rendPlayer;

    private void Awake()
    {
        rendPlayer = GetComponent<SpriteRenderer>();
    }
    void Start ()
    {

	}
	
	void Update ()
    {
		if (Input.GetButton("Player01Down"))
        {
            rendPlayer.sprite = playerDown;
        }
        if (Input.GetButtonUp("Player01Down"))
        {
            rendPlayer.sprite = playerIdle;
        }
    }
}
