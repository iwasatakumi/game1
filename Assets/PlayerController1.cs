using System.Collections;
using UnityEngine;

public class PlayerController1 : MonoBehaviour 
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");	
		float z = Input.GetAxis("Vertical");		


		Rigidbody rigidbody = GetComponent<Rigidbody>();


		rigidbody.AddForce(x * 7, 0, z * 20);
	}
}