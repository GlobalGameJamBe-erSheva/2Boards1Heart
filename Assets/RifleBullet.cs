using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleBullet : MonoBehaviour
{
	[field: SerializeField] public int force;
	Rigidbody rb;
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * force, ForceMode.Impulse);
	}
}
