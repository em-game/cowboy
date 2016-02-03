using UnityEngine;
using System.Collections;

public class CowboyCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _skeletonSound;
    private AudioSource _cactusSound;

    //Public Instance Variables
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._cactusSound = this._audioSources[1];
        this._skeletonSound = this._audioSources[2];
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
        }
        if (other.gameObject.CompareTag("cactus"))
        {
            this._cactusSound.Play();            
        }
    }
}
