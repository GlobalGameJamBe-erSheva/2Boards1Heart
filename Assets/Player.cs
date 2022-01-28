using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerMovement movement;
    PlayerInput input;

	public void Start()
	{
		movement = GetComponent<PlayerMovement>();
		movement.InitSelf();

		input = GetComponent<PlayerInput>();
	}

	public Vector3 GetDirectionVector()
	{
		return input.GetDirectionVector();
	}
}
