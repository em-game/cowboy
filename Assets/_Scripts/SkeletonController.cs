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

public class SkeletonController : MonoBehaviour {
    // Public Instance Variables
    public float speed = 6f;

    //Private Instance Variables
    private Transform _transform;
    private Vector2 _currentPosition;

    //Use this for initialization
    void Start()
    {
        //Make a reference with the Transform Component
        this._transform = gameObject.GetComponent<Transform>();
        
        // Reset the Skeleton Sprite to the Top
        this.Reset();
    }

    //Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.x <= -530)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        float yPosition = Random.Range(-160f, 160f);
        this._transform.position = new Vector2(530f, yPosition);
    }
}
