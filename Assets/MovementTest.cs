using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {

    float speed = 10;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        var translation = Input.GetAxis("Horizontal") * speed;

        translation *= Time.deltaTime;

        transform.Translate(translation, 0, 0);
	}
}
