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

        if (this._currentPosition.x <= -560)
        {
            this.Reset();
        }
    }

    public void Reset()
    {
        this._horizontalSpeed = Random.Range(this.minHorizontalSpeed, this.maxHorizontalSpeed);
        this._verticalDrift = Random.Range(this.minVerticalSpeed, this.maxVerticalSpeed);
        float yPosition = Random.Range(-110f, 110f);
        this._transform.position = new Vector2(560f, yPosition);
    }
}
