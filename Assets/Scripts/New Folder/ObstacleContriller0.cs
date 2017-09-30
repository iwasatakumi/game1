using System.Collections;
using UnityEngine;

public class ObstacleController : MonoBehaviour 
{
	
	private void OnTriggerEnter (Collider hit)
	{
		
		if (hit.CompareTag ("Player")) 
		{
			
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
	}
}