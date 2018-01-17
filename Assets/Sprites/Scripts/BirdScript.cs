using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    float jumpForce = 300f;
    float forwardSpeed = 2f;
    public bool dead = false; 
    public GameObject cam;
    public Rigidbody2D pajaro;
    
	// Use this for initialization
	void Start () {
        pajaro = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //   pajaro.velocity = Vector2.zero;
        if (dead == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                pajaro.AddForce(Vector2.up * jumpForce);
            }
            pajaro.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            if (transform.position.x >= 52.31)
            {
                dead = true;
            }
        }

	}
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }

}
