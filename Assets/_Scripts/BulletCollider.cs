﻿/*
Source file name : https://github.com/em-game/cowboy.git
Author : Eunmi Han(300790610)
Date last Modified : Feb 05, 2016
Program Description : SideScroller shooting game 
Revision History :1.11

Last Modified by Eunmi Han
*/
using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour
{
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _cactusSound;
    private AudioSource _skeletonSound;
           
    //Public Instance Variables
    public GameController gameController;
    public CactusController cactus;
    public SkeletonController skeleton;
    public BulletController bulletController;
    
    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._skeletonSound = this._audioSources[1];
        this._cactusSound = this._audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("skeleton"))
        {
            this._skeletonSound.Play();
            this.gameController.ScoreValue += 100;
            Destroy(other.gameObject);
            Instantiate(skeleton.gameObject);
            bulletController.Reset();

        }
        if (other.gameObject.CompareTag("cactus"))
        {
            this._cactusSound.Play();
            this.gameController.ScoreValue += 50;
            Destroy(other.gameObject);
            Instantiate(cactus.gameObject);
            bulletController.Reset();
        }
        
    }
}
