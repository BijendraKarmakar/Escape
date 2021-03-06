﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed = 300;
    public GameObject character;

    private Rigidbody characterBody;
    private float ScreenWidth;

	// Use this for initialization
	void Start () {
        ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        int i = 0;

        while (i < Input.touchCount)
        {
            if (Input.GetTouch (i).position.x > ScreenWidth / 2)
            {
                RunCharacter(1.0f);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                RunCharacter(-1.0f);
            }
            ++i;
        }
	}

    void FixedUpdate()
    {
        #if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
        #endif
    }

    private void RunCharacter(float horizontalInput)
    {
        characterBody.AddForce( horizontalInput * moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
