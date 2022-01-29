using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	[field: SerializeField] public int force;
	new BoxCollider boundsTrigger;
	Rigidbody rb;
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * force, ForceMode.Impulse);
	}

	public void SetTrigger(BoxCollider i_Collider)
	{
		boundsTrigger = i_Collider;
		print(boundsTrigger.gameObject.name);
	}

	private void Update()
	{
		if(boundsTrigger)
		if(!boundsTrigger.ClosestPoint(transform.position).Equals(transform.position))
		{
			Destroy(gameObject);
		}
	}
}
