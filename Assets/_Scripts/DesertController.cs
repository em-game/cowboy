﻿using UnityEngine;
using System.Collections;

public class DesertController : MonoBehaviour {
    //Public Instance Variables
    public float speed = 5f;

    //Private Instance Variables
    private Transform _transform;
    private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        //Reset the Island Sprite to the Top
        this.Reset();	
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -936)
        {
            this.Reset();
        }
	}

    public void Reset()
    {
        this._transform.position = new Vector2(933f, 0);
    }
}
