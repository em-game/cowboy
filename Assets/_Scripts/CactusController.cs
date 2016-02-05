/*
Source file name : https://github.com/em-game/cowboy.git
Author : Eunmi Han(300790610)
Date last Modified : Feb 05, 2016
Program Description : SideScroller shooting game 
Revision History :1.11

Last Modified by Eunmi Han
*/
using UnityEngine;
using System.Collections;

public class CactusController : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public float minVerticalSpeed = 5f;
    public float maxVerticalSpeed = 10f;
    public float minHorizontalSpeed = -2f;
    public float maxHorizontalSpeed = 2f;
    

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
    private Vector2 _currentPosition;
    private float _horizontalSpeed;
    private float _verticalDrift;

    // Use this for initialization
    void Start()
    {
        // Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();

        // Reset the Cloud Sprite to the Top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this._verticalDrift, this._horizontalSpeed);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -500)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(-160f, 160f);
        this._transform.position = new Vector2(500f, yPosition);
    }
}
