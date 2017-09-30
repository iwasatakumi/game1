using System.Collections;
using UnityEngine;

public class ObstacleController1 : MonoBehaviour 
{

	public UIController2 UIController2;

	private void OnCollisionEnter (Collision hit)
	{

		if (hit.collider.CompareTag ("Player")) 
		{

			hit.collider.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;

			UIController2.ShowGameOverLabel();
		}
	}
}