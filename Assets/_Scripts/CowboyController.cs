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

public class CowboyController : MonoBehaviour {
    //Public Instance Variables
    public float speed = 4f;
    public GameController gameController;

    //Private Instance Variables
    private float _cowboyInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        this._transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;

        this._cowboyInput = Input.GetAxis("Vertical");
        // if player input is positive move up
        if (this._cowboyInput > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);
        }

        // if player input is negative move down 
        if (this._cowboyInput < 0)
        {
            this._currentPosition -= new Vector2(0, this.speed);
        }

        this._cowboyInput = Input.GetAxis("Horizontal");
        // if player input is positive move right
        if (this._cowboyInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        // if player input is negative move left 
        if (this._cowboyInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }

        this._checkBounds();

        this._transform.position = this._currentPosition;
        
    }


    //Private Methods
    private void _checkBounds()
    {
        // check if the plane is going out of bounds and keep it inside window boundary
        if (this._currentPosition.y < -160)
        {
            this._currentPosition.y = -160;
        }

        if (this._currentPosition.y > 160)
        {
            this._currentPosition.y = 160;
        }

        if (this._currentPosition.x < -435)
        {
            this._currentPosition.x = -435;
        }

        if (this._currentPosition.x > 435)
        {
            this._currentPosition.x = 435;
        }
    }
}
