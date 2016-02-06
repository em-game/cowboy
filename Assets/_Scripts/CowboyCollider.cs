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

public class CowboyCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _cowboySound;
    private AudioSource _starSound;
    
    //Public Instance Variables
    public GameController gameController;
    public CactusController cactus;
    public SkeletonController skeleton;
    public StarController star;
        
    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._cowboySound = this._audioSources[1];
        this._starSound = this._audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("skeleton"))
        {
            this._cowboySound.Play();
            this.gameController.LivesValue -= 1;
            Destroy(other.gameObject);            
            Instantiate(skeleton.gameObject);

        }
        if (other.gameObject.CompareTag("cactus"))
        {
            this._cowboySound.Play();
            this.gameController.LivesValue -= 1;
            Destroy(other.gameObject);
            Instantiate(cactus.gameObject);
        }

        if (other.gameObject.CompareTag("star"))
        {
            this._starSound.Play();
            this.star.Reset();
            this.gameController.ScoreValue += 75;
        }
    }
}
