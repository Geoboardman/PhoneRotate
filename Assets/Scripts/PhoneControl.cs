using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneControl : MonoBehaviour {

    int speed = 50;
    Quaternion newRotation = Quaternion.identity;
	// Use this for initialization
	void Start () {
		
	}

	//This function takes in a Vector3, which is just an array of 3 float values
    //It creates a new rotation angle for the object based on the 3 values
    //And slowly rotates the object from its current rotation, to the new one
    //Based on the speed variable at the top.

    public void RotatePhone(Vector3 angles)
    {
        newRotation = Quaternion.Euler(angles);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, Time.deltaTime * speed);
    }

	// Update is called once per frame
	void Update () {
        RotatePhone(new Vector3(0, 90, 0));

        //The code below will rotate an object base on key presses
        /*
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
        */
    }
}
