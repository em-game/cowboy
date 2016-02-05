using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{

    //Public Instance Variables
    public float speed = 7f;
    public CowboyController cowboy;

    //Private Instance Variables
    private float _bulletInput;
    private Transform _transform;
    private Vector2 _currentPosition;
    private bool _chekcBullet = false;
	
    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        //this._currentPosition = this._transform.position;

        if (this._chekcBullet==false)
        {
            this.gameObject.SetActive(true);

            if (Input.GetMouseButton(0))
            {
                Debug.Log("mouse");
                this._chekcBullet = true;
                this._transform.position = new Vector2(cowboy.transform.position.x +150, cowboy.transform.position.y);            
            }

            if (Input.GetKeyDown("space"))
            {
                Debug.Log("keyboard");
                this._chekcBullet = true;
                this._transform.position = new Vector2(cowboy.transform.position.x + 150, cowboy.transform.position.y);
            
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
