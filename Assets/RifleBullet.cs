using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleBullet : MonoBehaviour
{
	Rigidbody rb;
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * 10, ForceMode.Impulse);
	}
}
