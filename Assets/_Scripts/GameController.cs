using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    // PUBLIC INSTANCE VARIABLES
    public int cactusNumber = 3;
    public CactusController cactus;

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

        for (int cactusCount = 0; cactusCount < this.cactusNumber; cactusCount++)
        {
            Instantiate(cactus.gameObject);
        }
    }
}
