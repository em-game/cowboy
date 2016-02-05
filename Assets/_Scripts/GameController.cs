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
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

    [SerializeField]
    private AudioSource _gameOverSound;

        
    // PUBLIC INSTANCE VARIABLES
    public int cactusNumber = 3;
    public SkeletonController skeleton;
    public CactusController cactus;
    public CowboyController cowboy;
    public BulletController bullet;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighScoreLabel;
    public Button RestartButton;

    // Public Access Methods
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score:" + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lves:" + this._livesValue;
            }
        }
    }
    
	// Use this for initialization
	void Start () {
        this._initialize();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Initial Method
    private void _initialize()
    {
        this.ScoreValue = 0;
        this.LivesValue = 5;
        this.GameOverLabel.enabled = false;
        this.HighScoreLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(false);
        this.skeleton.gameObject.SetActive(true);
        
        Instantiate(skeleton.gameObject);
        
        for (int cactusCount = 0; cactusCount < this.cactusNumber; cactusCount++)
        {
            Instantiate(cactus.gameObject);
        }

        
    }

    private void _endGame()
    {
        this.HighScoreLabel.text = "High Score: " + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.HighScoreLabel.enabled = true;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.cowboy.gameObject.SetActive(false);
        this.bullet.gameObject.SetActive(false);
        this._gameOverSound.Play();
        this.RestartButton.gameObject.SetActive(true);
    }

    // PUBLIC METHODS

    public void RestartButtonClick()
    {
        Application.LoadLevel("Main");
    }
}
