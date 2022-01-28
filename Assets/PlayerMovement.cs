using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] float movementSpeed;

	Player player;
	Rigidbody rb;
	
	public void InitSelf()
	{
		player = GetComponent<Player>();
		rb = GetComponent<Rigidbody>();
	}


	private void Update()
	{
		ApplyMovement();	
	}

	public void ApplyMovement()
	{
		Vector3 direction = player.GetDirectionVector();
		Vector3 movementVector = direction * movementSpeed * Time.deltaTime;
		rb.MovePosition(transform.position + movementVector);
	}
}
