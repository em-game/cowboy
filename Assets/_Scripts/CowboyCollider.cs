using UnityEngine;
using System.Collections;

public class CowboyCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _cowboySound;
    
    //Public Instance Variables
    public GameController gameController;
    public CactusController cactus;
    public SkeletonController skeleton;
    
    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._cowboySound = this._audioSources[1];        
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
    }
}
