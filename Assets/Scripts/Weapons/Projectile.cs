using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	[field: SerializeField] public int force;
	[SerializeField] int damage;
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
	}

	private void Update()
	{
		if(boundsTrigger)
		if(!boundsTrigger.ClosestPoint(transform.position).Equals(transform.position))
		{
			Destroy(gameObject);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Enemy"))
		{
			collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
		}

		else if (collision.gameObject.CompareTag("Boundry"))
		{
			Destroy(gameObject);
		}
	}
}
