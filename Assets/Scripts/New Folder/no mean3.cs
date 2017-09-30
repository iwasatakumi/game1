using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal");
		float Z = Input.GetAxis ("Vertical"); 

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce (x * 4, 0, Z * 4);
	}
}

