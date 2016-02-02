using UnityEngine;
using System.Collections;

public class CowboyController : MonoBehaviour {
    //Public Instance Variables
    public float speed = 5f;

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

        this._checkBounds();

        this._transform.position = this._currentPosition;
    }


    //Private Methods
    private void _checkBounds()
    {
        // check if the plane is going out of bounds and keep it inside window boundary
        if (this._currentPosition.y < -110)
        {
            this._currentPosition.y = -110;
        }

        if (this._currentPosition.y > 110)
        {
            this._currentPosition.y = 110;
        }
    }
}
