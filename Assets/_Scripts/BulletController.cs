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

public class BulletController : MonoBehaviour
{

    //Public Instance Variables
    public float speed = 7f;
    public CowboyController cowboyController;
    
    //Private Instance Variables
    private float _bulletInput;
    private Transform _transform;
    private Vector2 _currentPosition;
    private bool _chekcBullet = false;

    private AudioSource _gunSound;
    	
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();

        this._gunSound = gameObject.GetComponent<AudioSource>();
        
        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        //this._currentPosition = this._transform.position;

        if (this._chekcBullet==false)
        {
            
            if (Input.GetMouseButton(0))
            {
                _gunSound.Play();
                this._chekcBullet = true;
                this._transform.position = new Vector2(this.cowboyController.transform.position.x + 150, this.cowboyController.transform.position.y);
            }

            if (Input.GetKeyDown("space"))
            {
                _gunSound.Play();
                this._chekcBullet = true;
                this._transform.position = new Vector2(this.cowboyController.transform.position.x + 150, this.cowboyController.transform.position.y);
            
            }
            
        }

        this._currentPosition = this._transform.position;
        this._currentPosition += new Vector2(this.speed, 0);

        this._transform.position = this._currentPosition;

        if (this._currentPosition.x >= 468)
        {
            this._chekcBullet = false;
            this.Reset();
        }
	}
    
    public void Reset()
    {
        this._transform.position = new Vector2(530, 530); 
    }

}
