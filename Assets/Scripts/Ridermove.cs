using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ridermove : MonoBehaviour {

    public float speed = 1f;
    Rigidbody2D ERB;
	// Use this for initialization
	void Start () {
        ERB = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 v = new Vector2(speed, 0);
        ERB.velocity = v;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Flip();
    }
    void Flip()
    {
        speed *= -1f;
        var s = transform.localScale;
        s.x *= -1f;
        transform.localScale = s;
    }
}
