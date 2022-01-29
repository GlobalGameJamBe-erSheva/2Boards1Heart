using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
	// Start is called before the first frame update
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Player"))
		{
			print("player wounded");
			collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(25);
		}
	}
}
