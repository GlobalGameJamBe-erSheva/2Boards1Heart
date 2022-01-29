using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerMovement movement;
	PlayerAttacking attacking;
    PlayerInput input;

	public void Start()
	{
		movement = GetComponent<PlayerMovement>();
		movement.InitSelf();

		input = GetComponent<PlayerInput>();

		attacking = GetComponent<PlayerAttacking>();
		attacking.InitSelf();
	}

	public Vector3 GetDirectionVector()
	{
		return input.GetDirectionVector();
	}

	public bool IsAttacking()
	{
		return input.IsAttacking();
	}

	public void Die()
	{
		print(gameObject.name + "Is Dead!");
		Destroy(gameObject);
	}
}
