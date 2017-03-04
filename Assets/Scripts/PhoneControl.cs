using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneControl : MonoBehaviour {

    int speed = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
